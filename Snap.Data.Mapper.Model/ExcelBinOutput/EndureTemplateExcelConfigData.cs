namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class EndureTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("gaugeLength")]
    public double GaugeLength { get; set; }

    [JsonPropertyName("waneSpeed")]
    public double WaneSpeed { get; set; }

    [JsonPropertyName("recoverTime")]
    public double RecoverTime { get; set; }

    [JsonPropertyName("endurance")]
    public double Endurance { get; set; }
}