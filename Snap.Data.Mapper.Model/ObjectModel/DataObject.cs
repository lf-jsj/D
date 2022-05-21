using System.Text.Json;

namespace Snap.Data.Mapper.Model.ObjectModel;
public class DataObject
{
    private IDictionary<string, JsonElement>? extensionData;

    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get => extensionData; set => extensionData = value; }
}