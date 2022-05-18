namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityWatcherConfigData : DataObject
{
    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }

    [JsonPropertyName("activitychallengetipsTextMapHash")]
    public Text ActivitychallengetipsTextMapHash { get; set; }

    [JsonPropertyName("extraActivitychallengetipsTextMapHash")]
    public Text ExtraActivitychallengetipsTextMapHash { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    [JsonPropertyName("isAutoGrant")]
    public bool? IsAutoGrant { get; set; }
}