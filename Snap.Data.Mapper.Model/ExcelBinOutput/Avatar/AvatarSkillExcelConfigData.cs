namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarSkillExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("abilityName")]
    public string AbilityName { get; set; } = string.Empty;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("skillIcon")]
    public string SkillIcon { get; set; } = string.Empty;

    [JsonPropertyName("costStamina")]
    public float CostStamina { get; set; }

    [JsonPropertyName("maxChargeNum")]
    public int MaxChargeNum { get; set; }

    [JsonPropertyName("lockShape")]
    public string LockShape { get; set; } = default!;

    [JsonPropertyName("lockWeightParams")]
    public IList<float> LockWeightParams { get; set; } = default!;

    [JsonPropertyName("isAttackCameraLock")]
    public bool IsAttackCameraLock { get; set; }

    [JsonPropertyName("buffIcon")]
    public string BuffIcon { get; set; } = string.Empty;

    [JsonPropertyName("globalValueKey")]
    public string GlobalValueKey { get; set; } = string.Empty;

    [JsonPropertyName("cdTime")]
    public float? CdTime { get; set; }

    [JsonPropertyName("triggerID")]
    public int? TriggerID { get; set; }

    [JsonPropertyName("dragType")]
    public string? DragType { get; set; }

    [JsonPropertyName("showIconArrow")]
    public bool? ShowIconArrow { get; set; }

    [JsonPropertyName("proudSkillGroupId")]
    public int? ProudSkillGroupId { get; set; }

    [JsonPropertyName("forceCanDoSkill")]
    public bool? ForceCanDoSkill { get; set; }

    [JsonPropertyName("costElemType")]
    public string? CostElemType { get; set; }

    [JsonPropertyName("costElemVal")]
    public float? CostElemVal { get; set; }

    [JsonPropertyName("ignoreCDMinusRatio")]
    public bool? IgnoreCDMinusRatio { get; set; }

    [JsonPropertyName("isRanged")]
    public bool? IsRanged { get; set; }

    [JsonPropertyName("needMonitor")]
    public string? NeedMonitor { get; set; }

    [JsonPropertyName("defaultLocked")]
    public bool? DefaultLocked { get; set; }

    [JsonPropertyName("needStore")]
    public bool? NeedStore { get; set; }

    [JsonPropertyName("cdSlot")]
    public int? CdSlot { get; set; }

    [JsonPropertyName("energyMin")]
    public float? EnergyMin { get; set; }

    [JsonPropertyName("APONDIJMMMB")]
    public int? APONDIJMMMB { get; set; }
}