using Snap.Data.Mapper.Abstraction;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;
public class TextMapHashConverter : JsonConverter<TextMapHash>
{
    private readonly ITextMap textMap;

    public TextMapHashConverter(ITextMap textMap)
    {
        this.textMap = textMap;
    }

    public override TextMapHash? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new(textMap[reader.GetString()] ?? string.Empty);
    }

    public override void Write(Utf8JsonWriter writer, TextMapHash value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value);
    }
}

public class TextMapHash
{
    public TextMapHash(string value)
    {
        Value = value;
    }

    public string Value { get; set; }
}

