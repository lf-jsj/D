namespace Snap.Data.Mapper.Model.ExcelBinOutput.H5Activity;

public class H5ActivityWatcherExcelConfigData : DataObject
{
    [JsonPropertyName("h5ActivityId")]
    public int H5ActivityId { get; set; }

    [JsonPropertyName("condComb")]
    public string CondComb { get; set; } = default!;

    [JsonPropertyName("condList")]
    public IList<ParamStrCond> CondList { get; set; } = default!;

    [JsonPropertyName("isDailyRefresh")]
    public bool IsDailyRefresh { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }
}