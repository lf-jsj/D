namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ParamListType : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;
}
