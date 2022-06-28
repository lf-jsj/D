using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Avatar.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Weapon;

public class WeaponGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;

    private readonly IEnumerable<WeaponExcelConfigData> weapons;
    private readonly IEnumerable<WeaponCurveExcelConfigData> weaponCurves;
    private readonly IDictionary<int, IEnumerable<WeaponPromoteExcelConfigData>> weaponPromoteMap;

    public WeaponGenerator(
        string outputFolder,
        JsonSerializerOptions options,
        IEnumerable<WeaponExcelConfigData> weapons,
        IEnumerable<WeaponCurveExcelConfigData> weaponCurves,
        IDictionary<int, IEnumerable<WeaponPromoteExcelConfigData>> weaponPromoteMap)
    {
        this.outputFolder = outputFolder;
        this.options = options;
        this.weapons = weapons;
        this.weaponCurves = weaponCurves;
        this.weaponPromoteMap = weaponPromoteMap;
    }

    public void Generate()
    {
        IEnumerable<Model.Weapon> resultCache = weapons
            .Where(w => !string.IsNullOrEmpty(w.NameTextMapHash.Value))
            .Where(w => !w.NameTextMapHash.Value.Contains("test"))
            .Select(weapon => new Model.Weapon
            {
                WeaponType = weapon.WeaponType,
                RankLevel = weapon.RankLevel,
                Property = GetProperties(weapon, weaponCurves, weaponPromoteMap),
                AwakenIcon = weapon.AwakenIcon,
                Id = weapon.Id,
                Name = weapon.NameTextMapHash.Value,
                Description = weapon.DescTextMapHash.Value,
                Icon = weapon.Icon,
            });

        IPipeline.GenerateFile<Model.Weapon>(resultCache, outputFolder, options);
    }

    public PropertyInfo GetProperties(
        WeaponExcelConfigData item,
        IEnumerable<WeaponCurveExcelConfigData> weaponCurves,
        IDictionary<int, IEnumerable<WeaponPromoteExcelConfigData>> weaponPromoteMap)
    {
        IList<WeaponPromoteExcelConfigData> promotes = weaponPromoteMap[item.WeaponPromoteId].ToList();
        //IList<FightPropTypeValue> addProps = item.WeaponProp.Select(x => x.PropType).ToList();
        IList<FightProperty> propertyList = item.WeaponProp.Select(x => x.PropType).ToList();


        IList<WeaponProp> propGrow = item.WeaponProp;

        List<LevelParam2> resultCache = new()
        {
            // 0 p
            new() { Level = "1", Parameters = GetPropertyValues(item, 1, 0, propertyList, propGrow, promotes), },
            new() { Level = "20", Parameters = GetPropertyValues(item, 20, 0, propertyList, propGrow, promotes), },
            // 20 p
            new() { Level = "20+", Parameters = GetPropertyValues(item, 20, 1, propertyList, propGrow, promotes), },
            new() { Level = "40", Parameters = GetPropertyValues(item, 40, 1, propertyList, propGrow, promotes), },
            // 40 p
            new() { Level = "40+", Parameters = GetPropertyValues(item, 40, 2, propertyList, propGrow, promotes), },
            new() { Level = "50", Parameters = GetPropertyValues(item, 50, 2, propertyList, propGrow, promotes), },
            // 50 p
            new() { Level = "50+", Parameters = GetPropertyValues(item, 50, 3, propertyList, propGrow, promotes), },
            new() { Level = "60", Parameters = GetPropertyValues(item, 60, 3, propertyList, propGrow, promotes), },
            // 60 p
            new() { Level = "60+", Parameters = GetPropertyValues(item, 60, 4, propertyList, propGrow, promotes), },
            new() { Level = "70", Parameters = GetPropertyValues(item, 70, 4, propertyList, propGrow, promotes), },
        };

        if (item.RankLevel >= 3)
        {
            // 70 p
            resultCache.Add(new() { Level = "70+", Parameters = GetPropertyValues(item, 70, 5, propertyList, propGrow, promotes), });
            resultCache.Add(new() { Level = "80", Parameters = GetPropertyValues(item, 80, 5, propertyList, propGrow, promotes), });
            // 80 p
            resultCache.Add(new() { Level = "80+", Parameters = GetPropertyValues(item, 80, 6, propertyList, propGrow, promotes), });
            resultCache.Add(new() { Level = "90", Parameters = GetPropertyValues(item, 90, 6, propertyList, propGrow, promotes), });
        }

        return new PropertyInfo()
        {
            Properties = propertyList.Where(p => p != FightProperty.FIGHT_PROP_NONE),
            Parameters = resultCache,
        };
    }

    public IEnumerable<double> GetPropertyValues(
        WeaponExcelConfigData item,
        int level,
        int promoteIndex,
        IList<FightProperty> propertyList,
        IList<WeaponProp> propGrow,
        IList<WeaponPromoteExcelConfigData> promotes)
    {
        return propertyList
            .Where(p => p != FightProperty.FIGHT_PROP_NONE)
            .Select(p =>
            {
                // seek name in avatar's propGrowCurve
                string? curveName = propGrow.SingleOrDefault(x => x.PropType == p)?.Type;

                // seek curve in avatarCurves by curve name
                TypeArithValue? curve = weaponCurves.First(x => x.Level == level).CurveInfos.FirstOrDefault(x => x.Type == curveName);

                double baseValue = item.WeaponProp.First(x => x.PropType == p).InitValue;
                if (curve != null)
                {
                    baseValue *= curve.Value;
                }

                FightPropTypeValue? add = promotes[promoteIndex].AddProps.FirstOrDefault(x => x.PropType == p);
                if (add != null && add.Value.HasValue)
                {
                    baseValue += add.Value.Value;
                }
                return baseValue;
            });
    }
}
