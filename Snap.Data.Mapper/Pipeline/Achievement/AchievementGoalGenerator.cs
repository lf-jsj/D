using Microsoft;
using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reward;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Achievement.Model;
using System.Collections.Generic;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Achievement;

public class AchievementGoalGenerator
{
    private readonly string outputFolder;
    private readonly string compatFolder;
    private readonly JsonSerializerOptions options;

    private readonly IEnumerable<AchievementGoalExcelConfigData> goals;
    private readonly IDictionary<int, RewardExcelConfigData> rewardMap;

    public AchievementGoalGenerator(
        string outputFolder,
        string compatFolder,
        JsonSerializerOptions options,
        IEnumerable<AchievementGoalExcelConfigData> goals,
        IDictionary<int, RewardExcelConfigData> rewardMap)
    {
        this.outputFolder = outputFolder;
        this.compatFolder = compatFolder;
        this.options = options;
        this.goals = goals;
        this.rewardMap = rewardMap;
    }

    public void Generate()
    {
        List<AchievementGoal> achievementGoalCache = new();
        List<Model.SnapGenshin.SGAchievementGoal> compatGoalCache = new();
        foreach (AchievementGoalExcelConfigData item in goals)
        {
            SimpleReward? simpleReward = null;

            if (item.FinishRewardId.HasValue)
            {
                RewardExcelConfigData rewardExcelConfigData = rewardMap[item.FinishRewardId.Value];
                Verify.Operation(rewardExcelConfigData.RewardItemList[1].ItemId == null, "出现多个奖励内容");

                ItemIdItemCount reward = rewardExcelConfigData.RewardItemList[0];

                simpleReward = new()
                {
                    Id = reward.ItemId!.Value,
                    Count = reward.ItemCount!.Value,
                };
            }

            AchievementGoal achievementGoal = new()
            {
                Id = item.Id ?? 0,
                Order = item.OrderId,
                Name = item.NameTextMapHash.Value,
                FinishReward = simpleReward,
                Icon = string.IsNullOrEmpty(item.IconPath) ? null : item.IconPath,
            };

            Model.SnapGenshin.SGAchievementGoal compatGoal = new()
            {
                Id = item.Id ?? 0,
                OrderId = item.OrderId,
                Name = item.NameTextMapHash.Value,
                IconPath = string.IsNullOrEmpty(item.IconPath) ? null : item.IconPath,
            };

            achievementGoalCache.Add(achievementGoal);
            compatGoalCache.Add(compatGoal);
        }

        IPipeline.GenerateFile<AchievementGoal>(achievementGoalCache, outputFolder, options);
        IPipeline.GenerateFile("achievementgoals", compatGoalCache, compatFolder, options);
    }
}