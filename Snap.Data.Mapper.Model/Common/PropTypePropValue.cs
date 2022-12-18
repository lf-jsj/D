namespace Snap.Data.Mapper.Model.Common;

public class PropTypePropValue : DataObject
{
    [JsonPropertyName("PropType")]
    public string PropType { get; set; } = default!;

    [JsonPropertyName("PropValue")]
    public IList<float> PropValue { get; set; } = default!;
}
