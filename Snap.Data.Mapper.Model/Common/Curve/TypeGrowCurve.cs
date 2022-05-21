namespace Snap.Data.Mapper.Model.Common.Curve;

public class TypeGrowCurve : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("growCurve")]
    public string GrowCurve { get; set; } = default!;
}
