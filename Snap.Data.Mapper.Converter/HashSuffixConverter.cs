using Snap.Data.Mapper.Converter.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;

public class HashSuffixConverter : JsonConverter<HashSuffix>
{
    public override HashSuffix Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new(reader.GetUInt64());
    }

    public override void Write(Utf8JsonWriter writer, HashSuffix value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value.Value);
    }
}