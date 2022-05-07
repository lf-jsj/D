using Snap.Data.Mapper.Abstraction;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;
public class TextMapHashConverter : JsonConverter<string>
{
    private readonly ITextMap textMap;

    public TextMapHashConverter(ITextMap textMap)
    {
        this.textMap = textMap;
    }

    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return textMap[reader.GetString()];
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}
