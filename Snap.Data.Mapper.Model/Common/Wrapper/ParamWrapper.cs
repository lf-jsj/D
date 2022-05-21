namespace Snap.Data.Mapper.Model.Common.Wrapper;

public class ParamWrapper<T> : DataObject
{
    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;
}
