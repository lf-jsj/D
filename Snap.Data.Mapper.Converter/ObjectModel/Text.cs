namespace Snap.Data.Mapper.Converter.ObjectModel;

/// <summary>
/// Use for TextMapHash
/// </summary>
public struct Text
{
    public Text(string value)
    {
        Value = value;
    }

    public string Value { get; set; }
}