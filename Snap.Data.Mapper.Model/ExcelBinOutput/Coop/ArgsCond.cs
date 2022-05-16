namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;

public class ArgsCond : DataObject
{
    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;

    [JsonPropertyName("args")]
    public IList<int> Args { get; set; } = default!;
}
