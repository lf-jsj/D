namespace Snap.Data.Mapper.Model.Common;

public class IdType : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;
}
