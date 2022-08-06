using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
using Snap.Data.Mapper.Model.ExcelBinOutput.Daily;
using Snap.Data.Mapper.Model.ExcelBinOutput.Quest;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reward;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Achievement;

/// <summary>
/// 成就管线
/// </summary>
internal class AchievementPipeline : IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        string compatFolder = Path.Combine(Directory.GetParent(outputFolder)!.FullName, "Compat");

        // AchievementGoalExcelConfigData
        IEnumerable<AchievementGoalExcelConfigData> goals = IPipeline
            .GetData<AchievementGoalExcelConfigData>(genshinDataFolder, options);

        // RewardExcelConfigData
        IDictionary<int, RewardExcelConfigData> rewardMap = IPipeline
            .GetMap<RewardExcelConfigData>(genshinDataFolder, options, data => data.RewardId);

        new AchievementGoalGenerator(
            outputFolder,
            compatFolder,
            options,
            goals,
            rewardMap)
            .Generate();

        // AchievementExcelConfigData
        IEnumerable<AchievementExcelConfigData> excelData = IPipeline
            .GetData<AchievementExcelConfigData>(genshinDataFolder, options);

        // MainQuestExcelConfigData
        IDictionary<int, MainQuestExcelConfigData> mainQuests = IPipeline
            .GetMap<MainQuestExcelConfigData>(genshinDataFolder, options, data => data.Id);

        // QuestExcelConfigData
        IDictionary<int, QuestExcelConfigData> quests = IPipeline
            .GetMap<QuestExcelConfigData>(genshinDataFolder, options, data => data.SubId);

        // DailyTaskExcelConfigData
        IDictionary<int, DailyTaskExcelConfigData> dailyTasks = IPipeline
            .GetMap<DailyTaskExcelConfigData>(genshinDataFolder, options, data => data.ID);

        new AchievementGenerator(
            outputFolder,
            compatFolder,
            options,
            excelData,
            rewardMap,
            mainQuests,
            quests,
            dailyTasks)
            .Generate();
    }
}