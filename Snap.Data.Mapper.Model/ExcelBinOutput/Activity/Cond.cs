namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class Cond : DataObject
{
    [JsonPropertyName("param")]
    public IList<int> Param { get; set; } = default!;

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
