namespace Snap.Data.Mapper.Model.ExcelBinOutput.Forge;

public class MainRandomItem : DataObject
{
    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
