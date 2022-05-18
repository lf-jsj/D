namespace Snap.Data.Mapper.Model.ExcelBinOutput.World;

public class WorldAreaExploreEventConfigData : DataObject
{
    [JsonPropertyName("EventID")]
    public int EventID { get; set; }

    [JsonPropertyName("SceneID")]
    public int SceneID { get; set; }

    [JsonPropertyName("AreaID")]
    public int AreaID { get; set; }

    [JsonPropertyName("EventType")]
    public string EventType { get; set; } = default!;

    [JsonPropertyName("Param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("ExploreWeight")]
    public int ExploreWeight { get; set; }
}