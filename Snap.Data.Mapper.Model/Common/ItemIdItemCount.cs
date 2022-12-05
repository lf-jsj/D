namespace Snap.Data.Mapper.Model.Common;

public class ItemIdItemCount : DataObject
{
    public int ItemId { get; set; } = default!;

    public int ItemCount { get; set; }
}