namespace Snap.Data.Mapper.Converter.ObjectModel;

public struct HashPre
{
    public HashPre(ushort value)
    {
        Value = value;
    }

    public ushort Value { get; set; }

    public override string ToString()
    {
        return Value.ToString();
    }
}