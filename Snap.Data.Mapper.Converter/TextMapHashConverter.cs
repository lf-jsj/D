using Snap.Data.Mapper.Abstraction;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;
public class TextMapHashConverter : JsonConverter<MappedText>
{
    private readonly ITextMap textMap;

    public TextMapHashConverter(ITextMap textMap)
    {
        this.textMap = textMap;
    }

    public override MappedText Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new(textMap[reader.GetUInt64().ToString()] ?? string.Empty);
    }

    public override void Write(Utf8JsonWriter writer, MappedText value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value);
    }
}