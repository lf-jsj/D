namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Delivery;

public class ActivityDeliveryWatcherDataConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }
}
