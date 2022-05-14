namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Delivery;

public class DeliveryQuestConfig : DataObject
{
    [JsonPropertyName("parentQuestId")]
    public int ParentQuestId { get; set; }

    [JsonPropertyName("deliveryQuestId")]
    public int DeliveryQuestId { get; set; }

    [JsonPropertyName("startQuestId")]
    public int StartQuestId { get; set; }

    [JsonPropertyName("talkQuestId")]
    public int TalkQuestId { get; set; }

    [JsonPropertyName("watcherId")]
    public IList<int> WatcherId { get; set; } = default!;

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }
}
