namespace Snap.Data.Mapper.Model.Common;

public class ItemIdItemNum : DataObject
{
    [JsonPropertyName("itemId")]
    public int? ItemId { get; set; }

    [JsonPropertyName("itemNum")]
    public int? ItemNum { get; set; }
}

