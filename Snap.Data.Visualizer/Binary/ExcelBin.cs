using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Model.ExcelBinOutput.Ability;
using Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ArenaChallenge;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.CrystalLink;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Delivery;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Hachi;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.HideAndSeek;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MistTrial;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Photograph;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.PlantFlower;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Potion;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salesman;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Spice;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SteepleChase;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SummerTime;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Sumo;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Tanuki;
using Snap.Data.Mapper.Model.ExcelBinOutput.Animal;
using Snap.Data.Visualizer.Core.ComponentModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace Snap.Data.Visualizer.Binary;
internal class ExcelBin
{
    internal static IList<NamedValue<Lazy<IOutputHandler>>> Initialize(string genshinDataFolder)
    {
        string targetFolder = Path.Combine(genshinDataFolder, "ExcelBinOutput");

        return new List<NamedValue<Lazy<IOutputHandler>>>
        {
            Register<AbilityOverrideExcelConfigData>(targetFolder),
            Register<AbilityPropExcelConfigData>(targetFolder),
            Register<AbilityStateResistanceByIDExcelConfigData>(targetFolder),
            Register<AchievementExcelConfigData>(targetFolder),
            Register<AchievementGoalExcelConfigData>(targetFolder),
            Register<ActivityAbilityGroupExcelConfigData>(targetFolder),
            Register<ActivityArenaChallengeExcelConfigData>(targetFolder),
            Register<ActivityArenaChallengeLevelInfoExcelConfigData>(targetFolder),
            Register<ActivityArenaChallengePreviewExcelConfigData>(targetFolder),
            Register<ActivityBannerExcelConfigData>(targetFolder),
            Register<ActivityChessAffixExcelConfigData>(targetFolder),
            Register<ActivityChessCardExcelConfigData>(targetFolder),
            Register<ActivityChessGearExcelConfigData>(targetFolder),
            Register<ActivityChessLevelExcelConfigData>(targetFolder),
            Register<ActivityChessMapExcelConfigData>(targetFolder),
            Register<ActivityChessPreviewExcelConfigData>(targetFolder),
            Register<ActivityChessScheduleExcelConfigData>(targetFolder),
            Register<ActivityCrystalLinkCondBuffExcelConfigData>(targetFolder),
            Register<ActivityCrystalLinkDifficultyExcelConfigData>(targetFolder),
            Register<ActivityCrystalLinkEffectBuffExcelConfigData>(targetFolder),
            Register<ActivityCrystalLinkLevelExcelConfigData>(targetFolder),
            Register<ActivityDeliveryDailyExcelConfigData>(targetFolder),
            Register<ActivityDeliveryExcelConfigData>(targetFolder),
            Register<ActivityDeliveryWatcherDataConfigData>(targetFolder),
            Register<ActivityExcelConfigData>(targetFolder),
            Register<ActivityGroupLinksExcelConfigData>(targetFolder),
            Register<ActivityHachiFinalStageExcelConfigData>(targetFolder),
            Register<ActivityHachiStageExcelConfigData>(targetFolder),
            Register<ActivityHideAndSeekBasicConfigData>(targetFolder),
            Register<ActivityMistTrialAvatarDataExcelConfigData>(targetFolder),
            Register<ActivityMistTrialLevelDataExcelConfigData>(targetFolder),
            Register<ActivityMistTrialLevelFactorExcelConfigData>(targetFolder),
            Register<ActivityMistTrialStatisticsListExcelConfigData>(targetFolder),
            Register<ActivityMistTrialWatcherListDataExcelConfigData>(targetFolder),
            Register<ActivityPhotographExcelConfigData>(targetFolder),
            Register<ActivityPhotographPosExcelConfigData>(targetFolder),
            Register<ActivityPlantFlowerDailyExcelConfigData>(targetFolder),
            Register<ActivityPlantFlowerMainExcelConfigData>(targetFolder),
            Register<ActivityPotionBuffExcelConfigData>(targetFolder),
            Register<ActivityPotionDifficultyExcelConfigData>(targetFolder),
            Register<ActivityPotionLevelExcelConfigData>(targetFolder),
            Register<ActivityPotionModeChoiceExcelConfigData>(targetFolder),
            Register<ActivityPotionOverallExcelConfigData>(targetFolder),
            Register<ActivityPotionStageExcelConfigData>(targetFolder),
            Register<ActivitySalesmanDailyExcelConfigData>(targetFolder),
            Register<ActivitySalesmanExcelConfigData>(targetFolder),
            Register<ActivitySalesmanRewardMatchConfigData>(targetFolder),
            Register<ActivityShopOverallExcelConfigData>(targetFolder),
            Register<ActivityShopSheetExcelConfigData>(targetFolder),
            Register<ActivitySkillExcelConfigData>(targetFolder),
            Register<ActivitySpiceExcelConfigData>(targetFolder),
            Register<ActivitySpiceFoodExcelConfigData>(targetFolder),
            Register<ActivitySpiceGivingExcelConfigData>(targetFolder),
            Register<ActivitySpiceStageDataExcelConfigData>(targetFolder),
            Register<ActivitySteepleChaseConfigData>(targetFolder),
            Register<ActivitySummerTimeExcelConfigData>(targetFolder),
            Register<ActivitySummerTimeFloatSignalExcelConfigData>(targetFolder),
            Register<ActivitySummerTimeRaceExcelConfigData>(targetFolder),
            Register<ActivitySummerTimeRacePreviewExcelConfigData>(targetFolder),
            Register<ActivitySummerTimeStageExcelConfigData>(targetFolder),
            Register<ActivitySumoDifficultyExcelConfigData>(targetFolder),
            Register<ActivitySumoOverallConfigData>(targetFolder),
            Register<ActivitySumoStageExcelConfigData>(targetFolder),
            Register<ActivitySumoSwitchSkillExcelConfigData>(targetFolder),
            Register<ActivityTanukiTravelDataExcelConfigData>(targetFolder),
            Register<ActivityTanukiTravelRouteDataExcelConfigData>(targetFolder),
            Register<ActivityWatcherConfigData>(targetFolder),
            Register<AnimalCodexExcelConfigData>(targetFolder),
            Register<AnimalDescribeExcelConfigData>(targetFolder),
        };
    }

    private static NamedValue<Lazy<IOutputHandler>> Register<T>(string targetFolder)
        where T : class
    {
        return AsTyped<TypedExcelBinOutputHandler<T>>(targetFolder);
    }

    private static NamedValue<Lazy<IOutputHandler>> AsTyped<T>(string targetFolder)
        where T : IExcelBinOutputHandler
    {
        return new(
            typeof(T).GenericTypeArguments[0].Name,
            new(() => (T)Activator.CreateInstance(typeof(T), targetFolder)!));
    }
}
