namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class ParamListCondType : DataObject
{
    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;
}