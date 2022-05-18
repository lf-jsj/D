namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class SampleList : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("content")]
    public string Content { get; set; } = default!;
}
