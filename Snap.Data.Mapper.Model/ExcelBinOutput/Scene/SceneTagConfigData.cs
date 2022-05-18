namespace Snap.Data.Mapper.Model.ExcelBinOutput.Scene;

public class SceneTagConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sceneTagName")]
    public string SceneTagName { get; set; } = default!;

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("DICMHHHOHPE")]
    public bool DICMHHHOHPE { get; set; }

    [JsonPropertyName("cond")]
    public IList<Param2CondType> Cond { get; set; } = default!;

    [JsonPropertyName("isDefaultValid")]
    public bool? IsDefaultValid { get; set; }

    [JsonPropertyName("CEFAGPFLLPO")]
    public bool? CEFAGPFLLPO { get; set; }
}