using Snap.Data.Mapper.Model.Common.Curve;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarExcelConfigData : DataObject
{
    public BodyType BodyType { get; set; } = default!;

    public string IconName { get; set; } = default!;

    public string SideIconName { get; set; } = default!;

    public ItemQuality QualityType { get; set; } = default!;

    public double ChargeEfficiency { get; set; }

    public int InitialWeapon { get; set; }

    public WeaponType WeaponType { get; set; } = default!;

    public string ImageName { get; set; } = default!;

    public string CutsceneShow { get; set; } = string.Empty;

    public int SkillDepotId { get; set; }

    public double StaminaRecoverSpeed { get; set; }

    public IList<int> CandSkillDepotIds { get; set; } = default!;

    public Text DescTextMapHash { get; set; }

    public int AvatarPromoteId { get; set; }

    public IList<int> AvatarPromoteRewardLevelList { get; set; } = default!;

    public IList<int> AvatarPromoteRewardIdList { get; set; } = default!;

    public int FeatureTagGroupID { get; set; }

    public Text InfoDescTextMapHash { get; set; }

    public double HpBase { get; set; }

    public double AttackBase { get; set; }

    public double DefenseBase { get; set; }

    public double Critical { get; set; }

    public double CriticalHurt { get; set; }

    public IList<FightPropertyTypeGrowCurve> PropGrowCurves { get; set; } = default!;

    public int Id { get; set; }

    public Text NameTextMapHash { get; set; }

    public string LODPatternName { get; set; } = string.Empty;

    public int UseType { get; set; }

    public bool IsRangeAttack { get; set; }
}
