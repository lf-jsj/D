namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterExcelConfigData : DataObject
{
    [JsonPropertyName("monsterName")]
    public string MonsterName { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("scriptDataPathHashSuffix")]
    public HashSuffix ScriptDataPathHashSuffix { get; set; }

    [JsonPropertyName("scriptDataPathHashPre")]
    public HashPre ScriptDataPathHashPre { get; set; }

    [JsonPropertyName("serverScript")]
    public string ServerScript { get; set; } = default!;

    [JsonPropertyName("combatConfigHashSuffix")]
    public HashSuffix CombatConfigHashSuffix { get; set; }

    [JsonPropertyName("combatConfigHashPre")]
    public HashPre CombatConfigHashPre { get; set; }

    [JsonPropertyName("affix")]
    public IList<int> Affix { get; set; } = default!;

    [JsonPropertyName("ai")]
    public string Ai { get; set; } = default!;

    [JsonPropertyName("isAIHashCheck")]
    public bool IsAIHashCheck { get; set; }

    [JsonPropertyName("equips")]
    public IList<int> Equips { get; set; } = default!;

    [JsonPropertyName("hpDrops")]
    public IList<HpDrop> HpDrops { get; set; } = default!;

    [JsonPropertyName("killDropId")]
    public int KillDropId { get; set; }

    [JsonPropertyName("excludeWeathers")]
    public string ExcludeWeathers { get; set; } = default!;

    [JsonPropertyName("featureTagGroupID")]
    public int FeatureTagGroupID { get; set; }

    [JsonPropertyName("mpPropID")]
    public int MpPropID { get; set; }

    [JsonPropertyName("skin")]
    public string Skin { get; set; } = default!;

    [JsonPropertyName("describeId")]
    public int DescribeId { get; set; }

    [JsonPropertyName("combatBGMLevel")]
    public int CombatBGMLevel { get; set; }

    [JsonPropertyName("entityBudgetLevel")]
    public int EntityBudgetLevel { get; set; }

    [JsonPropertyName("hpBase")]
    public double HpBase { get; set; }

    [JsonPropertyName("attackBase")]
    public double AttackBase { get; set; }

    [JsonPropertyName("defenseBase")]
    public double DefenseBase { get; set; }

    [JsonPropertyName("fireSubHurt")]
    public double FireSubHurt { get; set; }

    [JsonPropertyName("grassSubHurt")]
    public double GrassSubHurt { get; set; }

    [JsonPropertyName("waterSubHurt")]
    public double WaterSubHurt { get; set; }

    [JsonPropertyName("elecSubHurt")]
    public double ElecSubHurt { get; set; }

    [JsonPropertyName("windSubHurt")]
    public double WindSubHurt { get; set; }

    [JsonPropertyName("iceSubHurt")]
    public double IceSubHurt { get; set; }

    [JsonPropertyName("rockSubHurt")]
    public double RockSubHurt { get; set; }

    [JsonPropertyName("propGrowCurves")]
    public IList<PropGrowCurve> PropGrowCurves { get; set; } = default!;

    [JsonPropertyName("physicalSubHurt")]
    public double PhysicalSubHurt { get; set; }

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

    [JsonPropertyName("campID")]
    public int CampID { get; set; }

    [JsonPropertyName("LODPatternName")]
    public string LODPatternName { get; set; } = default!;

    [JsonPropertyName("securityLevel")]
    public string SecurityLevel { get; set; } = default!;

    [JsonPropertyName("isInvisibleReset")]
    public bool? IsInvisibleReset { get; set; }

    [JsonPropertyName("safetyCheck")]
    public bool? SafetyCheck { get; set; }

    [JsonPropertyName("isSceneReward")]
    public bool? IsSceneReward { get; set; }

    [JsonPropertyName("visionLevel")]
    public string VisionLevel { get; set; } = default!;
}