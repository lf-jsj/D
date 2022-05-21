namespace Snap.Data.Mapper.Model.Common.Param;

public class TypeSubType : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("subType")]
    public string SubType { get; set; } = default!;
}
