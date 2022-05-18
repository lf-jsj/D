namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusWatcherExcelConfigData : DataObject
{
    [JsonPropertyName("rewardTokens")]
    public int RewardTokens { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }
}