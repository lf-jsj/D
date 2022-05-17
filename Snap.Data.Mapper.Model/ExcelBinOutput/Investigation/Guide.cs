namespace Snap.Data.Mapper.Model.ExcelBinOutput.Investigation;

public class Guide : DataObject
{
    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("guideScene")]
    public int? GuideScene { get; set; }

    [JsonPropertyName("guideStyle")]
    public string GuideStyle { get; set; } = default!;

    [JsonPropertyName("guideLayer")]
    public string GuideLayer { get; set; } = default!;
}
