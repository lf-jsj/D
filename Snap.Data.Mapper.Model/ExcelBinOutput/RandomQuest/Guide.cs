namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class Guide : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("guideScene")]
    public int GuideScene { get; set; }

    [JsonPropertyName("guideStyle")]
    public string GuideStyle { get; set; } = default!;
}
