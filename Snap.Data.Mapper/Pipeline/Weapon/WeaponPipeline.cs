using Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Weapon;
internal class WeaponPipeline : IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IEnumerable<WeaponExcelConfigData> weapons = IPipeline
            .GetData<WeaponExcelConfigData>(genshinDataFolder, options);

        IEnumerable<WeaponCurveExcelConfigData> weaponCurves = IPipeline
            .GetData<WeaponCurveExcelConfigData>(genshinDataFolder, options);

        IDictionary<int, IEnumerable<WeaponPromoteExcelConfigData>> weaponPromoteMap = IPipeline
            .GetData<WeaponPromoteExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.WeaponPromoteId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        new WeaponGenerator(
            outputFolder,
            options,
            weapons,
            weaponCurves,
            weaponPromoteMap)
            .Generate();
    }
}