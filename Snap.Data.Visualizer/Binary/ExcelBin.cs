using Snap.Data.Mapper.Abstraction;
using Snap.Data.Visualizer.Binary.ExcelBinOutput;
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
            FromType<AbilityOverrideExcelConfigDataHandler>(targetFolder),
            FromType<AbilityPropExcelConfigDataHandler>(targetFolder),
            FromType<AbilityStateResistanceByIDExcelConfigDataHandler>(targetFolder),
            FromType<AchievementExcelConfigDataHandler>(targetFolder),
        };
    }

    private static NamedValue<Lazy<IOutputHandler>> FromType<T>(string targetFolder)
        where T : IExcelBinOutputHandler
    {
        return new(
            typeof(T).Name.Replace("Handler", string.Empty),
            new(() => (T)Activator.CreateInstance(typeof(T),targetFolder)!));
    }
}
