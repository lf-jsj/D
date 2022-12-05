namespace Snap.Data.Mapper.Model.Common;

public class TypeArithValue : DataObject
{
    public int Type { get; set; } = default!;

    public int Arith { get; set; } = default!;

    public double Value { get; set; }
}
