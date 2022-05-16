namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.DragonSpine;

public class FinishExec : DataObject
{
    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}
