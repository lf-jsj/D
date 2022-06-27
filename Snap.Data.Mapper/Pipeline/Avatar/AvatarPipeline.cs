using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
using Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Avatar;

internal class AvatarPipeline : IPipeline
{
    // https://www.projectcelestia.com/static/images/UI_AvatarIcon_Albedo.webp
    // https://www.projectcelestia.com/static/images/Skill_S_Albedo_01.webp

    // https://upload-bbs.mihoyo.com/game_record/genshin/character_icon/{iconName}.png
    // https://upload-bbs.mihoyo.com/game_record/genshin/character_side_icon/{iconName}.png

    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IEnumerable<AvatarExcelConfigData> avatars = IPipeline
            .GetData<AvatarExcelConfigData>(genshinDataFolder, options);

        IDictionary<int, AvatarCodexExcelConfigData> avatarCodex = IPipeline
            .GetMap<AvatarCodexExcelConfigData>(genshinDataFolder, options, x => x.AvatarId);

        IEnumerable<AvatarCostumeExcelConfigData> avatarCostumes = IPipeline
            .GetData<AvatarCostumeExcelConfigData>(genshinDataFolder, options);

        IDictionary<int, AvatarSkillDepotExcelConfigData> skillDepotMap = IPipeline
            .GetMap<AvatarSkillDepotExcelConfigData>(genshinDataFolder, options, x => x.Id);

        IDictionary<int, AvatarSkillExcelConfigData> skills = IPipeline
            .GetMap<AvatarSkillExcelConfigData>(genshinDataFolder, options, x => x.Id);

        IDictionary<int, IEnumerable<ProudSkillExcelConfigData>> proudSkillsMap = IPipeline
            .GetData<ProudSkillExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.ProudSkillGroupId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        IDictionary<int, AvatarTalentExcelConfigData> talents = IPipeline
            .GetMap<AvatarTalentExcelConfigData>(genshinDataFolder, options, x => x.TalentId);

        IDictionary<int, FetterInfoExcelConfigData> fetterInfos = IPipeline
           .GetMap<FetterInfoExcelConfigData>(genshinDataFolder, options, x => x.AvatarId);

        IDictionary<int, IEnumerable<FettersExcelConfigData>> fettersMap = IPipeline
            .GetData<FettersExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.AvatarId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        IDictionary<int, IEnumerable<FetterStoryExcelConfigData>> fetterStoryMap = IPipeline
            .GetData<FetterStoryExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.AvatarId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        IEnumerable<AvatarCurveExcelConfigData> avatarCurves = IPipeline
            .GetData<AvatarCurveExcelConfigData>(genshinDataFolder, options);

        IDictionary<int, IEnumerable<AvatarPromoteExcelConfigData>> avatarPromoteMap = IPipeline
            .GetData<AvatarPromoteExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.AvatarPromoteId)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        new AvatarGenerator(
            outputFolder,
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
            avatarPromoteMap)
            .Generate();
    }
}