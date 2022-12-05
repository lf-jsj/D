namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponExcelConfigData : DataObject
{
    public WeaponType WeaponType { get; set; } = default!;

    public int RankLevel { get; set; }

    public IList<int> SkillAffix { get; set; } = default!;

    public IList<WeaponProp> WeaponProp { get; set; } = default!;

    public string AwakenIcon { get; set; } = default!;

    public int WeaponPromoteId { get; set; }

    public int Id { get; set; }

    public Text NameTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public string Icon { get; set; } = default!;
}