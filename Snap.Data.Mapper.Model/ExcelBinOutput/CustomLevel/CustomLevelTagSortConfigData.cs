namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomLevel;

public class CustomLevelTagSortConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("ACKHNDEOFHC")]
    public string ACKHNDEOFHC { get; set; } = default!;

    [JsonPropertyName("IDEKLMBOEHF")]
    public string IDEKLMBOEHF { get; set; } = default!;
}
