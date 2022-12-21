using Snap.Data.Mapper.Core.Extension;
using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.Common.Curve;
using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
using Snap.Data.Mapper.Model.ExcelBinOutput.Cook;
using Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;
using Snap.Data.Mapper.Model.ExcelBinOutput.Material;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Avatar.Model;
using Snap.Data.Mapper.Pipeline.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Avatar;

public class AvatarGenerator
{
    private readonly string outputFolder;
    private readonly string simpleFolder;
    private readonly JsonSerializerOptions options;

    private readonly IEnumerable<AvatarExcelConfigData> avatars;
    private readonly IEnumerable<AvatarCostumeExcelConfigData> avatarCostumes;
    private readonly IDictionary<int, AvatarSkillDepotExcelConfigData> skillDepotMap;
    private readonly IDictionary<int, AvatarSkillExcelConfigData> skills;
    private readonly IDictionary<int, IEnumerable<ProudSkillExcelConfigData>> proudSkillsMap;
    private readonly IDictionary<int, AvatarCodexExcelConfigData> avatarCodex;
    private readonly IDictionary<int, AvatarTalentExcelConfigData> talents;
    private readonly IDictionary<int, FetterInfoExcelConfigData> fetterInfos;
    private readonly IDictionary<int, IEnumerable<FettersExcelConfigData>> fettersMap;
    private readonly IDictionary<int, IEnumerable<FetterStoryExcelConfigData>> fetterStoryMap;
    private readonly IEnumerable<AvatarCurveExcelConfigData> avatarCurves;
    private readonly IDictionary<int, IEnumerable<AvatarPromoteExcelConfigData>> avatarPromoteMap;
    private readonly Dictionary<int, CookBonusExcelConfigData> cookBonusMap;
    private readonly IDictionary<int, MaterialExcelConfigData> materialMap;
    private readonly IDictionary<int, CookRecipeExcelConfigData> cookRecipeMap;


    private static readonly List<int> SkipAvatars = new()
    {
        10000005, 10000007,
    };

    public AvatarGenerator(
        string outputFolder,
        string simpleFolder,
        JsonSerializerOptions options,
        IEnumerable<AvatarExcelConfigData> avatars,
        IEnumerable<AvatarCostumeExcelConfigData> avatarCostumes,
        IDictionary<int, AvatarSkillDepotExcelConfigData> skillDepotMap,
        IDictionary<int, AvatarSkillExcelConfigData> skills,
        IDictionary<int, IEnumerable<ProudSkillExcelConfigData>> proudSkillsMap,
        IDictionary<int, AvatarCodexExcelConfigData> avatarCodex,
        IDictionary<int, AvatarTalentExcelConfigData> talents,
        IDictionary<int, FetterInfoExcelConfigData> fetterInfos,
        IDictionary<int, IEnumerable<FettersExcelConfigData>> fettersMap,
        IDictionary<int, IEnumerable<FetterStoryExcelConfigData>> fetterStoryMap,
        IEnumerable<AvatarCurveExcelConfigData> avatarCurves,
        IDictionary<int, IEnumerable<AvatarPromoteExcelConfigData>> avatarPromoteMap,
        Dictionary<int, CookBonusExcelConfigData> cookBonusMap,
        IDictionary<int, MaterialExcelConfigData> materialMap,
        IDictionary<int, CookRecipeExcelConfigData> cookRecipeMap)
    {
        this.outputFolder = outputFolder;
        this.simpleFolder = simpleFolder;
        this.options = options;

        this.avatars = avatars;
        this.avatarCostumes = avatarCostumes;
        this.skillDepotMap = skillDepotMap;
        this.skills = skills;
        this.proudSkillsMap = proudSkillsMap;
        this.avatarCodex = avatarCodex;
        this.talents = talents;
        this.fetterInfos = fetterInfos;
        this.fettersMap = fettersMap;
        this.fetterStoryMap = fetterStoryMap;
        this.avatarCurves = avatarCurves;
        this.avatarPromoteMap = avatarPromoteMap;
        this.cookBonusMap = cookBonusMap;
        this.materialMap = materialMap;
        this.cookRecipeMap = cookRecipeMap;
    }

    public void Generate()
    {
        List<Model.Avatar> resultsCache = new();
        foreach (AvatarExcelConfigData avatar in avatars)
        {
            if (ShouldSkip(avatar))
            {
                continue;
            }

            // parse skillDepot
            AvatarSkillDepotExcelConfigData avatarSkillDepot = skillDepotMap[avatar.SkillDepotId];
            IEnumerable<SkillInfo> skills = avatarSkillDepot.Skills
                .Where(id => id > 0)
                .Select(GetSkillInfoBySkillId);
            SkillInfo energySkill = GetSkillInfoBySkillId(avatarSkillDepot.EnergySkill);
            IEnumerable<Talent> talents = avatarSkillDepot.Talents
                .Select(GetTalentById);
            IEnumerable<SkillInfo> inherents = avatarSkillDepot.InherentProudSkillOpens
                .Where(open => open.ProudSkillGroupId.HasValue)
                .Select(open => open.ProudSkillGroupId!.Value)
                .Select(GetSkillInfoByGroupId);
            SkillDepot skillDepot = new()
            {
                Skills = skills,
                EnergySkill = energySkill,
                Talents = talents,
                Inherents = inherents,
            };

            Model.Avatar result = new()
            {
                Body = avatar.BodyType,
                Icon = avatar.IconName,
                SideIcon = avatar.SideIconName,
                Quality = avatar.QualityType,
                Weapon = avatar.WeaponType,
                SkillDepot = skillDepot,
                Property = GetProperties(avatar),
                Id = avatar.Id,
                Name = avatar.NameTextMapHash.Value,
                BeginTime = avatarCodex[avatar.Id].BeginTime,
                Sort = avatarCodex[avatar.Id].SortId,
                Costumes = GetCostumes(avatar),
                FetterInfo = GetFetterInfoById(avatar.Id, fettersMap, fetterStoryMap),
                CultivationItems = GetCultivationItems(avatarPromoteMap[avatar.AvatarPromoteId].ToList(), proudSkillsMap[skillDepot.Skills.First().GroupId].ElementAt(9))
            };

            resultsCache.Add(result);
        }

        IPipeline.GenerateFile<Model.Avatar>(resultsCache, outputFolder, options);

        IEnumerable<IdName> simpleIdNames = avatars.Select(a => new IdName(a.Id, a.NameTextMapHash.Value));
        IPipeline.GenerateFile("Avatars",simpleIdNames, simpleFolder, options);
    }

    public static bool ShouldSkip(AvatarExcelConfigData item)
    {
        return item.UseType != "AVATAR_FORMAL"
            || SkipAvatars.Contains(item.Id);
    }

    public PropertyInfo GetProperties(
        AvatarExcelConfigData item)
    {
        IList<AvatarPromoteExcelConfigData> promotes = avatarPromoteMap[item.AvatarPromoteId].ToList();
        IList<FightPropTypeValue> addProps = promotes[0].AddProps;
        IList<FightProperty> propertyList = addProps.Select(prop => prop.PropType).ToList();


        IList<FightPropertyTypeGrowCurve> propGrow = item.PropGrowCurves;

        // 0 p
        LevelParam2 level1Info = new() { Level = "1", Parameters = GetPropertyValues(item, 1, 0, propertyList, propGrow, promotes), };
        LevelParam2 level20Info = new() { Level = "20", Parameters = GetPropertyValues(item, 20, 0, propertyList, propGrow, promotes), };
        // 20 p
        LevelParam2 level20pInfo = new() { Level = "20+", Parameters = GetPropertyValues(item, 20, 1, propertyList, propGrow, promotes), };
        LevelParam2 level40Info = new() { Level = "40", Parameters = GetPropertyValues(item, 40, 1, propertyList, propGrow, promotes), };
        // 40 p
        LevelParam2 level40pInfo = new() { Level = "40+", Parameters = GetPropertyValues(item, 40, 2, propertyList, propGrow, promotes), };
        LevelParam2 level50Info = new() { Level = "50", Parameters = GetPropertyValues(item, 50, 2, propertyList, propGrow, promotes), };
        // 50 p
        LevelParam2 level50pInfo = new() { Level = "50+", Parameters = GetPropertyValues(item, 50, 3, propertyList, propGrow, promotes), };
        LevelParam2 level60Info = new() { Level = "60", Parameters = GetPropertyValues(item, 60, 3, propertyList, propGrow, promotes), };
        // 60 p
        LevelParam2 level60pInfo = new() { Level = "60+", Parameters = GetPropertyValues(item, 60, 4, propertyList, propGrow, promotes), };
        LevelParam2 level70Info = new() { Level = "70", Parameters = GetPropertyValues(item, 70, 4, propertyList, propGrow, promotes), };
        // 70 p
        LevelParam2 level70pInfo = new() { Level = "70+", Parameters = GetPropertyValues(item, 70, 5, propertyList, propGrow, promotes), };
        LevelParam2 level80Info = new() { Level = "80", Parameters = GetPropertyValues(item, 80, 5, propertyList, propGrow, promotes), };
        // 80 p
        LevelParam2 level80pInfo = new() { Level = "80+", Parameters = GetPropertyValues(item, 80, 6, propertyList, propGrow, promotes), };
        LevelParam2 level90Info = new() { Level = "90", Parameters = GetPropertyValues(item, 90, 6, propertyList, propGrow, promotes), };

        return new PropertyInfo()
        {
            Properties = addProps.Select(prop => prop.PropType),
            Parameters = new List<LevelParam2>()
            {
                level1Info,
                level20Info,
                level20pInfo,
                level40Info,
                level40pInfo,
                level50Info,
                level50pInfo,
                level60Info,
                level60pInfo,
                level70Info,
                level70pInfo,
                level80Info,
                level80pInfo,
                level90Info
            },
        };
    }

    public IEnumerable<float> GetPropertyValues(
        AvatarExcelConfigData item,
        int level,
        int promoteIndex,
        IList<FightProperty> propertyList,
        IList<FightPropertyTypeGrowCurve> propGrow,
        IList<AvatarPromoteExcelConfigData> promotes)
    {
        return propertyList
            .Select(p =>
            {
                // seek name in avatar's propGrowCurve
                string? curveName = propGrow.SingleOrDefault(x => x.Type == p)?.GrowCurve;

                // seek curve in avatarCurves by curve name
                TypeArithValue? curve = avatarCurves.First(x => x.Level == level).CurveInfos.FirstOrDefault(x => x.Type == curveName);

                float baseValue = GetBaseValueByFightProperty(item, p);
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

    public static float GetBaseValueByFightProperty(AvatarExcelConfigData item, FightProperty prop)
    {
        return prop switch
        {
            FightProperty.FIGHT_PROP_BASE_HP => item.HpBase,
            FightProperty.FIGHT_PROP_BASE_DEFENSE => item.DefenseBase,
            FightProperty.FIGHT_PROP_BASE_ATTACK => item.AttackBase,
            FightProperty.FIGHT_PROP_CRITICAL => item.Critical,
            FightProperty.FIGHT_PROP_CRITICAL_HURT => item.CriticalHurt,
            FightProperty.FIGHT_PROP_CHARGE_EFFICIENCY => item.ChargeEfficiency,
            // other properties always start from 0
            _ => 0,
        };
    }

    private FetterInfo GetFetterInfoById(
        int id,
        IDictionary<int, IEnumerable<FettersExcelConfigData>> fettersMap,
        IDictionary<int, IEnumerable<FetterStoryExcelConfigData>> fetterStoryMap)
    {
        IEnumerable<Fetter> fetters = fettersMap[id].Select(x => {
            return new Fetter
            {
                Title = x.VoiceTitleTextMapHash.Value,
                Context = x.VoiceFileTextTextMapHash.Value.Replace(@"\n", "\n"),
            };
        });

        IEnumerable<Fetter> fetterStories = fetterStoryMap[id].Select(x => new Fetter
        {
            Title = x.StoryTitleTextMapHash.Value,
            Context = x.StoryContextTextMapHash.Value.Replace(@"\n", "\n"),
        });

        CookBonusExcelConfigData? cookBonusData = cookBonusMap.GetValueOrDefault(id);
        CookBonus2? cookBonus2 = null;
        if (cookBonusData != null)
        {
            CookRecipeExcelConfigData recipeData = cookRecipeMap[cookBonusData.RecipeId];
            MaterialExcelConfigData materialData = materialMap[cookBonusData.ParamVec[0]];

            cookBonus2 = new()
            {
                OriginItemId = recipeData.QualityOutputVec[1].Id ?? 0,
                ItemId = cookBonusData.ParamVec[0],
                InputList = recipeData.InputVec.Where(x => x.Count > 0).Select(idCount => idCount.Id ?? 0).ToList(),
            };
        }
        

        FetterInfoExcelConfigData fetterData = fetterInfos[id];

        FetterInfo fetterInfo = new()
        {
            BirthMonth = fetterData.InfoBirthMonth,
            BirthDay = fetterData.InfoBirthDay,
            Native = fetterData.AvatarNativeTextMapHash.Value,
            VisionBefore = fetterData.AvatarVisionBeforTextMapHash.Value,
            VisionAfter = fetterData.AvatarVisionAfterTextMapHash.Value,
            ConstellationBefore = fetterData.AvatarConstellationBeforTextMapHash.Value,
            ConstellationAfter = fetterData.AvatarConstellationAfterTextMapHash.Value,
            Title = fetterData.AvatarTitleTextMapHash.Value,
            Detail = fetterData.AvatarDetailTextMapHash.Value,
            Association = fetterData.AvatarAssocType,
            CvChinese = fetterData.CvChineseTextMapHash.Value,
            CvJapanese = fetterData.CvJapaneseTextMapHash.Value,
            CvEnglish = fetterData.CvEnglishTextMapHash.Value,
            CvKorean = fetterData.CvKoreanTextMapHash.Value,
            CookBonus2 = cookBonus2,
            Fetters = fetters,
            FetterStories = fetterStories,
        };

        return fetterInfo;
    }

    private SkillInfo GetSkillInfoBySkillId(int skillId)
    {
        AvatarSkillExcelConfigData avatarSkill = skills[skillId];
        int proudSkillGroupId = avatarSkill.ProudSkillGroupId!.Value;

        IEnumerable<ProudSkillExcelConfigData> proudSkills = proudSkillsMap[proudSkillGroupId];

        // only first one's description is enough
        // others description should be the same
        IEnumerable<string> descriptions = proudSkills
            .First()
            .ParamDescList
            .Select(hash => hash.Value)
            .Where(text => !string.IsNullOrEmpty(text));

        IEnumerable<LevelParam> levelParams = proudSkills
            .Select(ps => new LevelParam
            {
                Level = ps.Level,
                Parameters = ps.ParamList.SkipLastWhile(i => i == 0D),
            });

        DescParam proud = new()
        {
            Descriptions = descriptions,
            Parameters = levelParams,
        };

        return new SkillInfo()
        {
            Id = avatarSkill.Id,
            GroupId = proudSkillGroupId,
            Name = avatarSkill.NameTextMapHash.Value,
            Description = avatarSkill.DescTextMapHash.Value.Replace(@"\n", "\n"),
            Icon = avatarSkill.SkillIcon,
            Proud = proud,
        };
    }

    private SkillInfo GetSkillInfoByGroupId(int groupId)
    {
        IEnumerable<ProudSkillExcelConfigData> proudSkills = proudSkillsMap[groupId];

        ProudSkillExcelConfigData first = proudSkills.First();

        IEnumerable<string> descriptions = first
            .ParamDescList
            .Select(x => x.Value)
            .Where(x => !string.IsNullOrEmpty(x));

        IEnumerable<LevelParam> levelParams = proudSkills
            .Select(ps => new LevelParam
            {
                Level = ps.Level,
                Parameters = ps.ParamList.SkipLastWhile(i => i == 0D),
            });

        DescParam proud = new()
        {
            Descriptions = descriptions,
            Parameters = levelParams,
        };

        return new SkillInfo()
        {
            Id = first.ProudSkillId,
            Name = first.NameTextMapHash.Value,
            Description = first.DescTextMapHash.Value.Replace(@"\n", "\n"),
            Icon = first.Icon,
            Proud = proud,
        };
    }

    private Talent GetTalentById(int id)
    {
        AvatarTalentExcelConfigData data = talents[id];

        return new Talent
        {
            Id = data.TalentId,
            Name = data.NameTextMapHash.Value,
            Description = data.DescTextMapHash.Value.Replace(@"\n", "\n"),
            Icon = data.Icon,
        };
    }

    private IEnumerable<Costume> GetCostumes(AvatarExcelConfigData item)
    {
        return avatarCostumes
            .Where(c => c.AvatarId == item.Id)
            .Select(c => new Costume()
            {
                Id = c.Id,
                Name = c.NameTextMapHash.Value,
                Description = c.DescTextMapHash.Value.Replace(@"\n", "\n"),
                IsDefault = c.IsDefault,
                Icon = c.IconName == string.Empty ? null : c.IconName,
                SideIcon = c.SideIconName == string.Empty ? null : c.SideIconName,
            });
    }

    private static List<int> GetCultivationItems(List<AvatarPromoteExcelConfigData> promoteData, ProudSkillExcelConfigData level10Data)
    {
        List<int> items = new();

        foreach(AvatarPromoteExcelConfigData data in promoteData)
        {
            if(data.PromoteLevel == 6)
            {
                items.AddRange(data.CostItems.Select(i => i.Id ?? 0));
            }
        }

        items.Add(level10Data.CostItems[0].Id ?? 0);
        items.Add(level10Data.CostItems[2].Id ?? 0);

        return items;
    }
}