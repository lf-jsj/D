namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class FailExec : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;
}
