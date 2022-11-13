namespace Snap.Data.Mapper.Converter.ObjectModel;

public struct HashPre
{
    public HashPre(ulong value)
    {
        Value = value;
    }

    public ulong Value { get; set; }

    public override string ToString()
    {
        return Value.ToString();
    }
}