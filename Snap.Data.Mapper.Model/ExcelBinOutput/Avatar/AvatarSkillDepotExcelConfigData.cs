namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarSkillDepotExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("energySkill")]
    public int EnergySkill { get; set; }

    [JsonPropertyName("skills")]
    public IList<int> Skills { get; set; } = default!;

    [JsonPropertyName("subSkills")]
    public IList<int> SubSkills { get; set; } = default!;

    [JsonPropertyName("extraAbilities")]
    public IList<string> ExtraAbilities { get; set; } = default!;

    [JsonPropertyName("talents")]
    public IList<int> Talents { get; set; } = default!;

    [JsonPropertyName("talentStarName")]
    public string TalentStarName { get; set; } = string.Empty;

    [JsonPropertyName("inherentProudSkillOpens")]
    public IList<InherentProudSkillOpen> InherentProudSkillOpens { get; set; } = default!;

    [JsonPropertyName("skillDepotAbilityGroup")]
    public string SkillDepotAbilityGroup { get; set; } = string.Empty;

    [JsonPropertyName("leaderTalent")]
    public int? LeaderTalent { get; set; }

    [JsonPropertyName("attackModeSkill")]
    public int? AttackModeSkill { get; set; }
}
