namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class CurveInfo : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("arith")]
    public string Arith { get; set; } = default!;

    [JsonPropertyName("value")]
    public double Value { get; set; }
}
