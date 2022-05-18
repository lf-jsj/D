namespace Snap.Data.Mapper.Model.ExcelBinOutput.World;

public class WorldAreaLevelupConfigData : DataObject
{
    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("areaId")]
    public int AreaId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("consumeItem")]
    public ConsumeItem ConsumeItem { get; set; } = default!;

    [JsonPropertyName("actionVec")]
    public IList<ActionVec> ActionVec { get; set; } = default!;
}