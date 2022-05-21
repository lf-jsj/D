namespace Snap.Data.Mapper.Model.Common.Param;

public class TypeParam<T> : DataObject
{

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<T> Param { get; set; } = default!;
}