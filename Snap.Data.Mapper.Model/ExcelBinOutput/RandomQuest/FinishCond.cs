namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class FinishCond : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("paramStr")]
    public string ParamStr { get; set; } = default!;

    [JsonPropertyName("count")]
    public string Count { get; set; } = default!;
}
