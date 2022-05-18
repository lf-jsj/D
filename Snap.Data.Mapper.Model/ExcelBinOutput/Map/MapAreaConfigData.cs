namespace Snap.Data.Mapper.Model.ExcelBinOutput.Map;
public class MapAreaConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sceneID")]
    public int SceneID { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("CGGPPNEAKFO")]
    public int CGGPPNEAKFO { get; set; }

    [JsonPropertyName("MGGOBIKCEOA")]
    public int MGGOBIKCEOA { get; set; }

    [JsonPropertyName("EHOENJAOPGJ")]
    public string EHOENJAOPGJ { get; set; } = default!;
}
