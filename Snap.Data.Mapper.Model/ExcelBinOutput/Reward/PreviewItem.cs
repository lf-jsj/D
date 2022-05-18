namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reward;

public class PreviewItem : DataObject
{
    [JsonPropertyName("count")]
    public string Count { get; set; } = default!;

    [JsonPropertyName("id")]
    public int? Id { get; set; }
}
