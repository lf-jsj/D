namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class PredicateConfig : DataObject
{
    [JsonPropertyName("predicateType")]
    public string PredicateType { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;
}
