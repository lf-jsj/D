namespace Snap.Data.Mapper.Model.ExcelBinOutput.Bored;

public class BoredEventExcelConfigData : DataObject
{
    [JsonPropertyName("eventType")]
    public string EventType { get; set; } = default!;

    [JsonPropertyName("param")]
    public int Param { get; set; }

    [JsonPropertyName("isEnable")]
    public bool IsEnable { get; set; }

    [JsonPropertyName("addBored")]
    public int AddBored { get; set; }

    [JsonPropertyName("maxBored")]
    public int MaxBored { get; set; }
}