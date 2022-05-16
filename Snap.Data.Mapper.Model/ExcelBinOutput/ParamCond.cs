namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ParamCond : DataObject
{
    [JsonPropertyName("param")]
    public IList<int> Param { get; set; } = default!;

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
