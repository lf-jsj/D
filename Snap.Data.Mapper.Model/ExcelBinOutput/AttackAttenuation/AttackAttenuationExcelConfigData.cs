namespace Snap.Data.Mapper.Model.ExcelBinOutput.AttackAttenuation;
public class AttackAttenuationExcelConfigData : DataObject
{
    [JsonPropertyName("EPNPPBPKAHE")]
    public string EPNPPBPKAHE { get; set; } = default!;

    [JsonPropertyName("IJFDPDFAPID")]
    public float IJFDPDFAPID { get; set; }

    [JsonPropertyName("HKLKPLCKFPE")]
    public IList<float> HKLKPLCKFPE { get; set; } = default!;

    [JsonPropertyName("CDPAIBLMDJP")]
    public IList<float> CDPAIBLMDJP { get; set; } = default!;

    [JsonPropertyName("FKMBAONAGHD")]
    public IList<float> FKMBAONAGHD { get; set; } = default!;
}
