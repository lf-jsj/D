namespace Snap.Data.Mapper.Model.Common.Param;

public class TypeParamStr : DataObject
{
    [JsonPropertyName("paramStr")]
    public string ParamStr { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}
