namespace Snap.Data.Mapper.Model.Common;

public class ItemIdCountWeight : DataObject
{
    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
