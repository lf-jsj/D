namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ClientSceneTagConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sceneTagName")]
    public string SceneTagName { get; set; } = default!;

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("NGGAEPHNBHO")]
    public string NGGAEPHNBHO { get; set; } = default!;
}
