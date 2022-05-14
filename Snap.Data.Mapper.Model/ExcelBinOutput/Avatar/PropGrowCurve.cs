namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class PropGrowCurve : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("growCurve")]
    public string GrowCurve { get; set; } = default!;
}
