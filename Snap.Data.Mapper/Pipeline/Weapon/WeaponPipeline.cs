using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Weapon;
internal class WeaponPipeline : IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        string simpleFolder = Path.Combine(Directory.GetParent(outputFolder)!.FullName, "Simple");

        IEnumerable<WeaponExcelConfigData> weapons = IPipeline
            .GetData<WeaponExcelConfigData>(genshinDataFolder, options);

        IEnumerable<WeaponCurveExcelConfigData> weaponCurves = IPipeline
            .GetData<WeaponCurveExcelConfigData>(genshinDataFolder, options);

        IDictionary<int, IEnumerable<WeaponPromoteExcelConfigData>> weaponPromoteMap = IPipeline
            .GetData<WeaponPromoteExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.WeaponPromoteId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        IDictionary<int, IEnumerable<EquipAffixExcelConfigData>> equipAffixMap = IPipeline
            .GetData<EquipAffixExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x=>x.Id)
            .ToDictionary(group=>group.Key, group => group.AsEnumerable());

        new WeaponGenerator(
            outputFolder,
            simpleFolder,
            options,
            weapons,
            weaponCurves,
            weaponPromoteMap,
            equipAffixMap)
            .Generate();
    }
}