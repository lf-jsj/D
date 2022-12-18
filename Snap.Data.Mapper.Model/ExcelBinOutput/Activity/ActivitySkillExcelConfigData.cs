namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class ActivitySkillExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("skillTarget")]
    public string? SkillTarget { get; set; }

    [JsonPropertyName("abilityName")]
    public string AbilityName { get; set; } = default!;

    [JsonPropertyName("globalValueKey")]
    public string GlobalValueKey { get; set; } = default!;

    [JsonPropertyName("energyMin")]
    public int EnergyMin { get; set; }

    [JsonPropertyName("energyMax")]
    public int EnergyMax { get; set; }

    [JsonPropertyName("cdTime")]
    public float CdTime { get; set; }

    [JsonPropertyName("guideTime")]
    public float GuideTime { get; set; }

    [JsonPropertyName("skillIcon")]
    public string SkillIcon { get; set; } = default!;

    [JsonPropertyName("guideKey")]
    public IList<string> GuideKey { get; set; } = default!;

    [JsonPropertyName("guideOpenState")]
    public string? GuideOpenState { get; set; }

    [JsonPropertyName("unableTextTextMapHash")]
    public Text UnableTextTextMapHash { get; set; }

    [JsonPropertyName("channelTextTextMapHash")]
    public Text ChannelTextTextMapHash { get; set; }

    [JsonPropertyName("interruptTextTextMapHash")]
    public Text InterruptTextTextMapHash { get; set; }
}