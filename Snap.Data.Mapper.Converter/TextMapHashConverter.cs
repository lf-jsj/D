using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Converter.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;
public class TextMapHashConverter : JsonConverter<Text>
{
    private readonly ITextMap textMap;

    public TextMapHashConverter(ITextMap textMap)
    {
        this.textMap = textMap;
    }

    public override Text Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new(textMap[reader.GetUInt64().ToString()] ?? "[No Hash Entry Match]");
    }

    public override void Write(Utf8JsonWriter writer, Text value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value);
    }
}
