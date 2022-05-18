namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class OverflowTransformExcelConfigData : DataObject
{
    [JsonPropertyName("transformType")]
    public string TransformType { get; set; } = default!;

    [JsonPropertyName("transformId")]
    public int TransformId { get; set; }

    [JsonPropertyName("transformBaseCount")]
    public int TransformBaseCount { get; set; }

    [JsonPropertyName("transformResults")]
    public IList<TransformResult> TransformResults { get; set; } = default!;

    [JsonPropertyName("transformItemLimitType")]
    public string TransformItemLimitType { get; set; } = default!;
}