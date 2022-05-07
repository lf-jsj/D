using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Snap.Data.Visualizer.Core;
internal static class JsonContext
{
    private static JsonSerializerOptions options = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
    };

    public static JsonSerializerOptions Options { get => options; set => options = value; }

    public static T? ToObject<T>(Stream jsonStream)
    {
        return JsonSerializer.Deserialize<T>(jsonStream, options);
    }

    public static string Stringify(object obj)
    {
        return JsonSerializer.Serialize(obj, options);
    }
}
