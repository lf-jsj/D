namespace Snap.Data.Mapper.Model.Common;

public class IdCount<T> : DataObject
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("count")]
    public T? Count { get; set; }
}