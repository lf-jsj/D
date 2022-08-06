using Microsoft;
using Snap.Data.Mapper.Core.Extension;
using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
using Snap.Data.Mapper.Model.ExcelBinOutput.Daily;
using Snap.Data.Mapper.Model.ExcelBinOutput.Quest;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reward;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Achievement.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Achievement;

public class AchievementGenerator
{
    private readonly string outputFolder;
    private readonly string compatFolder;
    private readonly JsonSerializerOptions options;

    private readonly IEnumerable<AchievementExcelConfigData> achievementsData;
    private readonly IDictionary<int, RewardExcelConfigData> rewardMap;
    private readonly IDictionary<int, MainQuestExcelConfigData> mainQuests;
    private readonly IDictionary<int, QuestExcelConfigData> quests;
    private readonly IDictionary<int, DailyTaskExcelConfigData> dailyTasks;

    private static readonly List<int> ObsoleteIds = new()
    {
        84027, 82011, 82016, 82018, 84517, 84521, 81006, 81007, 81008, 81009, 81011, 81012, 81013, 81219,
    };

    public AchievementGenerator(
        string outputFolder,
        string compatFolder,
        JsonSerializerOptions options,
        IEnumerable<AchievementExcelConfigData> achievementsData,
        IDictionary<int, RewardExcelConfigData> rewardMap,
        IDictionary<int, MainQuestExcelConfigData> mainQuests,
        IDictionary<int, QuestExcelConfigData> quests,
        IDictionary<int, DailyTaskExcelConfigData> dailyTasks)
    {
        this.outputFolder = outputFolder;
        this.compatFolder = compatFolder;
        this.options = options;

        this.achievementsData = achievementsData;
        this.rewardMap = rewardMap;
        this.mainQuests = mainQuests;
        this.quests = quests;
        this.dailyTasks = dailyTasks;
    }

    public void Generate()
    {
        List<Model.Achievement> resultsCache = new();
        List<Model.SnapGenshin.SGAchievement> compatResults = new();

        foreach (AchievementExcelConfigData achievement in achievementsData!)
        {
            if (ShouldSkip(achievement))
            {
                continue;
            }

            // parse achievement reward
            RewardExcelConfigData reward = rewardMap[achievement.FinishRewardId];
            Verify.Operation(reward.RewardItemList[1].ItemId == null, "出现多个奖励内容");
            ItemIdItemCount rewardItem = reward.RewardItemList[0];
            SimpleReward simpleReward = new()
            {
                Id = rewardItem.ItemId!.Value,
                Count = rewardItem.ItemCount!.Value,
            };

            // parse achievement triggers
            IEnumerable<AchievementTrigger>? triggers = DescriptTrigger(achievement.TriggerConfig, mainQuests, quests, dailyTasks);

            Model.Achievement result = new()
            {
                Goal = achievement.GoalId,
                Order = achievement.OrderId,
                Title = achievement.TitleTextMapHash.Value,
                Description = achievement.DescTextMapHash.Value,
                FinishReward = simpleReward,
                Id = achievement.Id,
                Triggers = triggers,
                Progress = achievement.Progress,
                Icon = string.IsNullOrEmpty(achievement.Icon) ? null : achievement.Icon,
            };

            Model.SnapGenshin.SGAchievement compatResult = new()
            {
                GoalId = achievement.GoalId,
                OrderId = achievement.OrderId,
                Title = achievement.TitleTextMapHash.Value,
                Description = achievement.DescTextMapHash.Value,
                FinishRewardCount = rewardItem.ItemCount!.Value,
                Id = achievement.Id,
            };

            resultsCache.Add(result);
            compatResults.Add(compatResult);
        }

        IPipeline.GenerateFile<Model.Achievement>(resultsCache, outputFolder, options);
        IPipeline.GenerateFile("achievements", compatResults, compatFolder, options);
    }

    private static bool ShouldSkip(AchievementExcelConfigData item)
    {
        return ObsoleteIds.Contains(item.Id)
            || (item.GoalId == 0 && item.OrderId == 0)
            || string.IsNullOrEmpty(item.TitleTextMapHash.Value);
    }

    public static IEnumerable<AchievementTrigger>? DescriptTrigger(
        ParamListTriggerConfig config,
        IDictionary<int, MainQuestExcelConfigData> mainQuests,
        IDictionary<int, QuestExcelConfigData> quests,
        IDictionary<int, DailyTaskExcelConfigData> dailyTasks)
    {
        string triggerType = config.TriggerType;

        // parent quests
        if (triggerType == "TRIGGER_FINISH_PARENT_QUEST_AND" || triggerType == "TRIGGER_FINISH_PARENT_QUEST_OR")
        {
            IEnumerable<string> notEmptyQuestIds = ProcessQuestIds(config.ParamList);

            IEnumerable<AchievementTrigger> results = notEmptyQuestIds
                .Select(id => mainQuests[int.Parse(id)])
                .Select(quest => new AchievementTrigger
                {
                    Id = quest.Id.ToString(),
                    Type = AchievementStepType.Quest,
                    Title = quest.TitleTextMapHash.Value,
                    Description = quest.DescTextMapHash.Value,
                });

            return results;
        }

        // quests
        if (triggerType == "TRIGGER_FINISH_QUEST_AND" || triggerType == "TRIGGER_FINISH_QUEST_OR")
        {
            IEnumerable<string> notEmptyQuestIds = ProcessQuestIds(config.ParamList);

            IEnumerable<AchievementTrigger> results = notEmptyQuestIds
                .Select(id => quests[int.Parse(id)])
                .Select(quest => new AchievementTrigger
                {
                    Id = $"{quest.MainId}-{quest.SubId}",
                    Type = AchievementStepType.SubQuest,
                    Title = mainQuests[quest.MainId].TitleTextMapHash.Value,
                    Description = quest.DescTextMapHash.Value,
                });

            return results;
        }

        // daily task
        if (triggerType == "TRIGGER_DAILY_TASK_VAR_EQUAL")
        {
            DailyTaskExcelConfigData task = dailyTasks[int.Parse(config.ParamList[0])];

            return new AchievementTrigger
            {
                Id = task.ID.ToString(),
                Type = AchievementStepType.DailyTask,
                Title = task.TitleTextMapHash.Value,
                Description = task.DescriptionTextMapHash.Value,
            }
            .Enumerate();
        }

        return null;
    }

    private static IEnumerable<string> ProcessQuestIds(IList<string> paramList)
    {
        IEnumerable<string> notEmptyQuestIds0 = paramList.Where(x => !string.IsNullOrEmpty(x));
        return string.Join(',', notEmptyQuestIds0).Split(',');
    }
}