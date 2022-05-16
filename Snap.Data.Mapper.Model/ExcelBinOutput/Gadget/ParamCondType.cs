namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class ParamCondType : DataObject
{
    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;
}