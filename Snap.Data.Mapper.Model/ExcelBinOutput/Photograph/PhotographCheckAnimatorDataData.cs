namespace Snap.Data.Mapper.Model.ExcelBinOutput.Photograph;

public class PhotographCheckAnimatorDataData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("INBAGHILKAE")]
    public int INBAGHILKAE { get; set; }

    [JsonPropertyName("DEIJOIDJPMP")]
    public IList<string> DEIJOIDJPMP { get; set; } = default!;

    [JsonPropertyName("GGPBPMLPJCN")]
    public IList<string> GGPBPMLPJCN { get; set; } = default!;
}