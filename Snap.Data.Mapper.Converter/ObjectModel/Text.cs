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

    public string UnescapedValue
    { 
        get
        {
            if (Value.StartsWith('#') && Value.Contains("REALNAME"))
            {
                return Value[1..].Replace("{REALNAME[ID(1)]}", "流浪者");
            }
            else
            {
                return Value;
            }
        }
    }

    public string Value { get; }

    public override string ToString()
    {
        return Value;
    }
}