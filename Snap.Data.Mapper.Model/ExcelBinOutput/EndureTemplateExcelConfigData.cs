namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class EndureTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("gaugeLength")]
    public float GaugeLength { get; set; }

    [JsonPropertyName("waneSpeed")]
    public float WaneSpeed { get; set; }

    [JsonPropertyName("recoverTime")]
    public float RecoverTime { get; set; }

    [JsonPropertyName("endurance")]
    public float Endurance { get; set; }
}