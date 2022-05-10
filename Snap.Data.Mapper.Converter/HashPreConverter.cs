using Snap.Data.Mapper.Converter.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;

public class HashPreConverter : JsonConverter<HashPre>
{
    public override HashPre Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new(reader.GetUInt16());
    }

    public override void Write(Utf8JsonWriter writer, HashPre value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value.Value);
    }
}
