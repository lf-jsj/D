namespace Snap.Data.Mapper.Model.Common.Param;

public class TypeParamParamStrCount<T> : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<T> Param { get; set; } = default!;

    [JsonPropertyName("paramStr")]
    public string ParamStr { get; set; } = default!;

    [JsonPropertyName("count")]
    public int Count { get; set; }
}
