using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Converter;

/// <summary>
/// 实现日期的转换
/// yyyy-MM-dd HH:mm:ss
/// </summary>
public class ParsedDateTimeConverter : JsonConverter<DateTime>
{
    private const string Format = "yyyy-MM-dd HH:mm:ss";

    /// <inheritdoc/>
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.GetString() is string dataTimeString)
        {
            return DateTime.ParseExact(dataTimeString,Format, CultureInfo.InvariantCulture);
        }

        return default;
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format));
    }
}