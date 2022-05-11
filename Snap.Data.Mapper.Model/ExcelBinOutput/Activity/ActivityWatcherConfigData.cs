namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class TriggerConfig : DataObject
{

    [JsonPropertyName("TriggerType")]
    public string TriggerType { get; set; } = default!;

    [JsonPropertyName("Param")]
    public IList<string> Param { get; set; } = default!;
}

public class ActivityWatcherConfigData : DataObject
{

    [JsonPropertyName("RewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("RewardPreview")]
    public int RewardPreview { get; set; }

    [JsonPropertyName("ActivitychallengetipsTextMapHash")]
    public Text ActivitychallengetipsTextMapHash { get; set; }

    [JsonPropertyName("ExtraActivitychallengetipsTextMapHash")]
    public Text ExtraActivitychallengetipsTextMapHash { get; set; }

    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("TriggerConfig")]
    public TriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("Progress")]
    public int Progress { get; set; }
}

