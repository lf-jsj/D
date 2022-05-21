namespace Snap.Data.Mapper.Model.Common;

public class ItemIdCountQuality : DataObject
{
    [JsonPropertyName("ItemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("Quality")]
    public int Quality { get; set; }
}
