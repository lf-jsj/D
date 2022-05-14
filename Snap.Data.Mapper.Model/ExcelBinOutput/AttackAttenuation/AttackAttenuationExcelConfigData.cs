namespace Snap.Data.Mapper.Model.ExcelBinOutput.AttackAttenuation;
public class AttackAttenuationExcelConfigData : DataObject
{
    [JsonPropertyName("EPNPPBPKAHE")]
    public string EPNPPBPKAHE { get; set; } = default!;

    [JsonPropertyName("IJFDPDFAPID")]
    public double IJFDPDFAPID { get; set; }

    [JsonPropertyName("HKLKPLCKFPE")]
    public IList<double> HKLKPLCKFPE { get; set; } = default!;

    [JsonPropertyName("CDPAIBLMDJP")]
    public IList<double> CDPAIBLMDJP { get; set; } = default!;

    [JsonPropertyName("FKMBAONAGHD")]
    public IList<double> FKMBAONAGHD { get; set; } = default!;
}
