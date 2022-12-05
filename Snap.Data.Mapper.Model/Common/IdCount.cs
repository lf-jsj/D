namespace Snap.Data.Mapper.Model.Common;

public class IdCount<T> : DataObject
{
    public int? Id { get; set; }

    public T? Count { get; set; }
}