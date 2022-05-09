using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Model.ExcelBinOutput.Ability;
using Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ArenaChallenge;
using Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;
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
            AsTyped<TypedExcelBinOutputHandler<AbilityOverrideExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<AbilityPropExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<AbilityStateResistanceByIDExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<AchievementExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<AchievementGoalExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityAbilityGroupExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityArenaChallengeExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityArenaChallengeLevelInfoExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityArenaChallengePreviewExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityBannerExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityChessAffixExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityChessCardExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityChessGearExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityChessLevelExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityChessMapExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityChessPreviewExcelConfigData>>(targetFolder),
            AsTyped<TypedExcelBinOutputHandler<ActivityChessScheduleExcelConfigData>>(targetFolder),
        };
    }

    private static NamedValue<Lazy<IOutputHandler>> AsTyped<T>(string targetFolder)
        where T : IExcelBinOutputHandler
    {
        return new(
            typeof(T).GenericTypeArguments[0].Name,
            new(() => (T)Activator.CreateInstance(typeof(T), targetFolder)!));
    }
}
