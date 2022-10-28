using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
using Snap.Data.Mapper.Model.ExcelBinOutput.Cook;
using Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;
using Snap.Data.Mapper.Model.ExcelBinOutput.Material;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Avatar;

internal class AvatarPipeline : IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        string simpleFolder = Path.Combine(Directory.GetParent(outputFolder)!.FullName, "Simple");

        // 角色
        IEnumerable<AvatarExcelConfigData> avatars = IPipeline
            .GetData<AvatarExcelConfigData>(genshinDataFolder, options);

        // 角色编号
        IDictionary<int, AvatarCodexExcelConfigData> avatarCodex = IPipeline
            .GetMap<AvatarCodexExcelConfigData>(genshinDataFolder, options, x => x.AvatarId);

        // 衣装
        IEnumerable<AvatarCostumeExcelConfigData> avatarCostumes = IPipeline
            .GetData<AvatarCostumeExcelConfigData>(genshinDataFolder, options);

        // 技能组
        IDictionary<int, AvatarSkillDepotExcelConfigData> skillDepotMap = IPipeline
            .GetMap<AvatarSkillDepotExcelConfigData>(genshinDataFolder, options, x => x.Id);

        // 技能
        IDictionary<int, AvatarSkillExcelConfigData> skills = IPipeline
            .GetMap<AvatarSkillExcelConfigData>(genshinDataFolder, options, x => x.Id);

        // 天赋
        IDictionary<int, IEnumerable<ProudSkillExcelConfigData>> proudSkillsMap = IPipeline
            .GetData<ProudSkillExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.ProudSkillGroupId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        // 命座
        IDictionary<int, AvatarTalentExcelConfigData> talents = IPipeline
            .GetMap<AvatarTalentExcelConfigData>(genshinDataFolder, options, x => x.TalentId);

        // 好感基本信息
        IDictionary<int, FetterInfoExcelConfigData> fetterInfos = IPipeline
           .GetMap<FetterInfoExcelConfigData>(genshinDataFolder, options, x => x.AvatarId);

        // 好感语音信息
        IDictionary<int, IEnumerable<FettersExcelConfigData>> fettersMap = IPipeline
            .GetData<FettersExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.AvatarId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        // 好感故事信息
        IDictionary<int, IEnumerable<FetterStoryExcelConfigData>> fetterStoryMap = IPipeline
            .GetData<FetterStoryExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.AvatarId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        // 角色升级曲线
        IEnumerable<AvatarCurveExcelConfigData> avatarCurves = IPipeline
            .GetData<AvatarCurveExcelConfigData>(genshinDataFolder, options);

        // 角色突破
        IDictionary<int, IEnumerable<AvatarPromoteExcelConfigData>> avatarPromoteMap = IPipeline
            .GetData<AvatarPromoteExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.AvatarPromoteId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        Dictionary<int, CookBonusExcelConfigData> cookBonusMap = IPipeline
            .GetData<CookBonusExcelConfigData>(genshinDataFolder, options)
            .ToDictionary(x => x.AvatarId);

        IDictionary<int, MaterialExcelConfigData> materialMap = IPipeline
            .GetData<MaterialExcelConfigData>(genshinDataFolder, options)
            .ToDictionary(x => x.Id);

        IDictionary<int, CookRecipeExcelConfigData> cookRecipeMap = IPipeline
            .GetData<CookRecipeExcelConfigData>(genshinDataFolder, options)
            .ToDictionary(x => x.Id);

        new AvatarGenerator(
            outputFolder,
            simpleFolder,
            options,
            avatars,
            avatarCostumes,
            skillDepotMap,
            skills,
            proudSkillsMap,
            avatarCodex,
            talents,
            fetterInfos,
            fettersMap,
            fetterStoryMap,
            avatarCurves,
            avatarPromoteMap,
            cookBonusMap,
            materialMap,
            cookRecipeMap)
            .Generate();
    }
}