namespace Snap.Data.Mapper.Model.Common.Wrapper;

public class ItemIdWrapper : DataObject
{
    [JsonPropertyName("ItemId")]
    public IList<int> ItemId { get; set; } = default!;
}
