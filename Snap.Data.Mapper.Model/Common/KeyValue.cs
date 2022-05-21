namespace Snap.Data.Mapper.Model.Common;

public class KeyValue : DataObject
{
    [JsonPropertyName("key")]
    public string Key { get; set; } = default!;

    [JsonPropertyName("value")]
    public double Value { get; set; }
}
