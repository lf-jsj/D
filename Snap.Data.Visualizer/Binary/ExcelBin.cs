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
            new(
                "AbilityOverrideExcelConfigData",
                new(() => new AbilityOverrideExcelConfigDataHandler(targetFolder))),
        };
    }
}
