namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ParamType : DataObject
{
    [JsonPropertyName("param")]
    public IList<int> Param { get; set; } = default!;

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
