namespace Snap.Data.Mapper.Model.Common;

public class ItemIdItemCount : DataObject
{
    [JsonPropertyName("itemId")]
    public int? ItemId { get; set; } = default!;

    [JsonPropertyName("itemCount")]
    public int? ItemCount { get; set; }
}