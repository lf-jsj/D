using Snap.Data.Mapper.Abstraction;
using Snap.Data.Visualizer.Binary.ExcelBinOutput.Ability;
using Snap.Data.Visualizer.Binary.ExcelBinOutput.Achievement;
using Snap.Data.Visualizer.Binary.ExcelBinOutput.Activity;
using Snap.Data.Visualizer.Binary.ExcelBinOutput.Activity.ArenaChallenge;
using Snap.Data.Visualizer.Binary.ExcelBinOutput.Activity.Chess;
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
            AsTyped<AbilityOverrideExcelConfigDataHandler>(targetFolder),
            AsTyped<AbilityPropExcelConfigDataHandler>(targetFolder),
            AsTyped<AbilityStateResistanceByIDExcelConfigDataHandler>(targetFolder),
            AsTyped<AchievementExcelConfigDataHandler>(targetFolder),
            AsTyped<AchievementGoalExcelConfigDataHandler>(targetFolder),
            AsTyped<ActivityAbilityGroupExcelConfigDataHandler>(targetFolder),
            AsTyped<ActivityArenaChallengeExcelConfigDataHandler>(targetFolder),
            AsTyped<ActivityArenaChallengeLevelInfoExcelConfigDataHandler>(targetFolder),
            AsTyped<ActivityArenaChallengePreviewExcelConfigDataHandler>(targetFolder),
            AsTyped<ActivityBannerExcelConfigDataHandler>(targetFolder),
            AsTyped<ActivityChessAffixExcelConfigDataHandler>(targetFolder),
            AsTyped<ActivityChessCardExcelConfigDataHandler>(targetFolder),
        };
    }

    private static NamedValue<Lazy<IOutputHandler>> AsTyped<T>(string targetFolder)
        where T : IExcelBinOutputHandler
    {
        return new(
            typeof(T).Name.Replace("Handler", string.Empty),
            new(() => (T)Activator.CreateInstance(typeof(T),targetFolder)!));
    }
}
