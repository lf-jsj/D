using Snap.Data.Mapper.Model.Common.Curve;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarExcelConfigData : DataObject
{
    [JsonPropertyName("bodyType")]
    public string BodyType { get; set; } = default!;

    [JsonPropertyName("scriptDataPathHashSuffix")]
    public HashSuffix ScriptDataPathHashSuffix { get; set; }

    [JsonPropertyName("scriptDataPathHashPre")]
    public HashPre ScriptDataPathHashPre { get; set; }

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("sideIconName")]
    public string SideIconName { get; set; } = default!;

    [JsonPropertyName("qualityType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ItemQuality QualityType { get; set; } = default!;

    [JsonPropertyName("chargeEfficiency")]
    public float ChargeEfficiency { get; set; }

    [JsonPropertyName("combatConfigHashSuffix")]
    public HashSuffix CombatConfigHashSuffix { get; set; }

    [JsonPropertyName("combatConfigHashPre")]
    public HashPre CombatConfigHashPre { get; set; }

    [JsonPropertyName("initialWeapon")]
    public int InitialWeapon { get; set; }

    [JsonPropertyName("weaponType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WeaponType WeaponType { get; set; } = default!;

    [JsonPropertyName("manekinPathHashSuffix")]
    public HashSuffix ManekinPathHashSuffix { get; set; }

    [JsonPropertyName("manekinPathHashPre")]
    public HashPre ManekinPathHashPre { get; set; }

    [JsonPropertyName("imageName")]
    public string ImageName { get; set; } = default!;

    [JsonPropertyName("gachaCardNameHashSuffix")]
    public HashSuffix GachaCardNameHashSuffix { get; set; }

    [JsonPropertyName("gachaCardNameHashPre")]
    public HashPre GachaCardNameHashPre { get; set; }

    [JsonPropertyName("cutsceneShow")]
    public string CutsceneShow { get; set; } = string.Empty;

    [JsonPropertyName("skillDepotId")]
    public int SkillDepotId { get; set; }

    [JsonPropertyName("staminaRecoverSpeed")]
    public float StaminaRecoverSpeed { get; set; }

    [JsonPropertyName("candSkillDepotIds")]
    public IList<int> CandSkillDepotIds { get; set; } = default!;

    [JsonPropertyName("manekinJsonConfigHashSuffix")]
    public HashSuffix ManekinJsonConfigHashSuffix { get; set; }

    [JsonPropertyName("manekinJsonConfigHashPre")]
    public HashPre ManekinJsonConfigHashPre { get; set; }

    [JsonPropertyName("manekinMotionConfig")]
    public int ManekinMotionConfig { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("avatarIdentityType")]
    public string? AvatarIdentityType { get; set; }

    [JsonPropertyName("avatarPromoteId")]
    public int AvatarPromoteId { get; set; }

    [JsonPropertyName("avatarPromoteRewardLevelList")]
    public IList<int> AvatarPromoteRewardLevelList { get; set; } = default!;

    [JsonPropertyName("avatarPromoteRewardIdList")]
    public IList<int> AvatarPromoteRewardIdList { get; set; } = default!;

    [JsonPropertyName("featureTagGroupID")]
    public int FeatureTagGroupID { get; set; }

    [JsonPropertyName("infoDescTextMapHash")]
    public Text InfoDescTextMapHash { get; set; }

    [JsonPropertyName("hpBase")]
    public float HpBase { get; set; }

    [JsonPropertyName("attackBase")]
    public float AttackBase { get; set; }

    [JsonPropertyName("defenseBase")]
    public float DefenseBase { get; set; }

    [JsonPropertyName("critical")]
    public float Critical { get; set; }

    [JsonPropertyName("criticalHurt")]
    public float CriticalHurt { get; set; }

    [JsonPropertyName("propGrowCurves")]
    public IList<FightPropertyTypeGrowCurve> PropGrowCurves { get; set; } = default!;

    [JsonPropertyName("prefabPathRagdollHashSuffix")]
    public HashSuffix PrefabPathRagdollHashSuffix { get; set; }

    [JsonPropertyName("prefabPathRagdollHashPre")]
    public HashPre PrefabPathRagdollHashPre { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("prefabPathHashSuffix")]
    public HashSuffix PrefabPathHashSuffix { get; set; }

    [JsonPropertyName("prefabPathHashPre")]
    public HashPre PrefabPathHashPre { get; set; }

    [JsonPropertyName("prefabPathRemoteHashSuffix")]
    public HashSuffix PrefabPathRemoteHashSuffix { get; set; }

    [JsonPropertyName("prefabPathRemoteHashPre")]
    public HashPre PrefabPathRemoteHashPre { get; set; }

    [JsonPropertyName("controllerPathHashSuffix")]
    public HashSuffix ControllerPathHashSuffix { get; set; }

    [JsonPropertyName("controllerPathHashPre")]
    public HashPre ControllerPathHashPre { get; set; }

    [JsonPropertyName("controllerPathRemoteHashSuffix")]
    public HashSuffix ControllerPathRemoteHashSuffix { get; set; }

    [JsonPropertyName("controllerPathRemoteHashPre")]
    public HashPre ControllerPathRemoteHashPre { get; set; }

    [JsonPropertyName("LODPatternName")]
    public string LODPatternName { get; set; } = string.Empty;

    [JsonPropertyName("useType")]
    public string? UseType { get; set; }

    [JsonPropertyName("gachaImageNameHashSuffix")]
    public HashSuffix? GachaImageNameHashSuffix { get; set; }

    [JsonPropertyName("gachaImageNameHashPre")]
    public HashPre? GachaImageNameHashPre { get; set; }

    [JsonPropertyName("isRangeAttack")]
    public bool? IsRangeAttack { get; set; }
}
