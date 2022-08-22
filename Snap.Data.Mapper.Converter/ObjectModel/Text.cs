namespace Snap.Data.Mapper.Converter.ObjectModel;

/// <summary>
/// Use for TextMapHash
/// </summary>
public struct Text
{
    public Text(ulong hash,string value)
    {
        Hash = hash;
        Value = value ?? string.Empty;
    }

    public ulong Hash { get; }

    public string Value { get; }

    public override string ToString()
    {
        return Value;
    }
}