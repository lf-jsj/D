using System.Text.Json;

namespace Snap.Data.Mapper.Model.ObjectModel;
public class DataObject
{
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? ExtensionData { get; set; }
}
