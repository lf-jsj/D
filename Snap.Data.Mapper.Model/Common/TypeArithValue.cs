namespace Snap.Data.Mapper.Model.Common;

public class TypeArithValue : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("arith")]
    public string Arith { get; set; } = default!;

    [JsonPropertyName("value")]
    public double Value { get; set; }
}
