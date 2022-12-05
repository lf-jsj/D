namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarSkillDepotExcelConfigData : DataObject
{
    public int Id { get; set; }

    public int EnergySkill { get; set; }

    public IList<int> Skills { get; set; } = default!;

    public IList<int> SubSkills { get; set; } = default!;

    public IList<string> ExtraAbilities { get; set; } = default!;

    public IList<int> Talents { get; set; } = default!;

    public string TalentStarName { get; set; } = string.Empty;

    public IList<InherentProudSkillOpen> InherentProudSkillOpens { get; set; } = default!;

    public string SkillDepotAbilityGroup { get; set; } = string.Empty;

    public int LeaderTalent { get; set; }

    public int AttackModeSkill { get; set; }
}
