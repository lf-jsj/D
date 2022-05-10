namespace Snap.Data.Mapper.Converter.ObjectModel;

public struct HashSuffix
{
    public HashSuffix(ulong value)
    {
        Value = value;
    }

    public ulong Value { get; set; }
}
