namespace Snap.Data.Mapper.Model.Common.Param;

public class TypeParamList : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;
}
