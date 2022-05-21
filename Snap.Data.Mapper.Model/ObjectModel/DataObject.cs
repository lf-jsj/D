using System.Text.Json;

namespace Snap.Data.Mapper.Model.ObjectModel;
public class DataObject
{
    private Dictionary<string, JsonElement>? extensionData;

    [JsonExtensionData]
    public Dictionary<string, JsonElement>? ExtensionData { get => extensionData; set => throw new InvalidOperationException("发现了未经处理的 Token。"); }
}