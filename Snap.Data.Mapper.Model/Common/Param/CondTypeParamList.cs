namespace Snap.Data.Mapper.Model.Common.Param;

public class CondTypeParamList : DataObject
{
    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;

    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;
}
