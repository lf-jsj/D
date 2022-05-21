namespace Snap.Data.Mapper.Model.Common.Param;

public class TypeContent : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("content")]
    public string Content { get; set; } = default!;
}
