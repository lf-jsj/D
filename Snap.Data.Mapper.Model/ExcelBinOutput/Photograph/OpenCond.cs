namespace Snap.Data.Mapper.Model.ExcelBinOutput.Photograph;

public class OpenCond : DataObject
{
    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;

    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;
}
