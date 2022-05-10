namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Delivery;

public class TriggerConfig : DataObject
{
    [JsonPropertyName("triggerType")]
    public string TriggerType { get; set; } = string.Empty;

    [JsonPropertyName("paramList")]
    public IList<string> ParamList { get; set; } = default!;
}

public class ActivityDeliveryWatcherDataConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public TriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }
}
