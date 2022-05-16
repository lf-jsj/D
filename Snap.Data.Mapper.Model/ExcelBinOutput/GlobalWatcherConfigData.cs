namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class GlobalWatcherConfigData : DataObject
{
    [JsonPropertyName("predicateConfigs")]
    public IList<PredicateConfig> PredicateConfigs { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }
}