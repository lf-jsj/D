namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reunion;

public class ReunionWatcherExcelConfigData : DataObject
{
    [JsonPropertyName("watcherGroupId")]
    public int WatcherGroupId { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("activateLevelRange")]
    public string ActivateLevelRange { get; set; } = default!;

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("NOJPGGIBBLL")]
    public int? NOJPGGIBBLL { get; set; }
}