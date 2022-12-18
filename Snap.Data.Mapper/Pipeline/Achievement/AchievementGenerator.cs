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
        84027, 82011, 82016, 82018, 84517,
        84521, 81006, 81007, 81008, 81009,
        81011, 81012, 81013, 81219, 82152,
        82153, 82154,
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

            Model.Achievement result = new()
            {
                Goal = achievement.GoalId,
                Order = achievement.OrderId,
                Title = achievement.TitleTextMapHash.Value,
                Description = ReplaceWithProgress(achievement.DescTextMapHash.Value, achievement.Progress),
                FinishReward = simpleReward,
                Id = achievement.Id,
                Progress = achievement.Progress,
                Icon = string.IsNullOrEmpty(achievement.Icon) ? null : achievement.Icon,
            };

            Model.SnapGenshin.SGAchievement compatResult = new()
            {
                GoalId = achievement.GoalId,
                OrderId = achievement.OrderId,
                Title = achievement.TitleTextMapHash.Value,
                Description = ReplaceWithProgress(achievement.DescTextMapHash.Value, achievement.Progress),
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
            || string.IsNullOrEmpty(item.TitleTextMapHash.Value)
            || item.TitleTextMapHash.Value.Contains("test")
            || item.TitleTextMapHash.Value == "废弃";
    }

    private static string ReplaceWithProgress(string input, int progress)
    {
        return input.Replace("{param0}", progress.ToString());
    }
}