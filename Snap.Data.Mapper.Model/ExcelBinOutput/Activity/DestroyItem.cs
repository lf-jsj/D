namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class DestroyItem : DataObject
{
    [JsonPropertyName("ItemId")]
    public IList<int> ItemId { get; set; } = default!;
}
