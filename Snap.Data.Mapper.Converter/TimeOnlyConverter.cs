using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;

public class TimeOnlyConverter : JsonConverter<TimeOnly>
{
    private const string Format = "HH:mm:ss";

    /// <inheritdoc/>
    public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.GetString() is string timeString)
        {
            return TimeOnly.ParseExact(timeString, Format);
        }

        return default;
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format));
    }
}