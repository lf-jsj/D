namespace Snap.Data.Mapper.Model.Common;

public class PropTypeValue : DataObject
{
    [JsonPropertyName("propType")]
    public string? PropType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
