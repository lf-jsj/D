namespace Snap.Data.Mapper.Model.ExcelBinOutput.World;
public class WorldAreaConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("SceneID")]
    public int SceneID { get; set; }

    [JsonPropertyName("AreaType")]
    public string AreaType { get; set; } = default!;

    [JsonPropertyName("AreaID1")]
    public int AreaID1 { get; set; }

    [JsonPropertyName("AreaNameTextMapHash")]
    public Text AreaNameTextMapHash { get; set; }

    [JsonPropertyName("towerPointId")]
    public int TowerPointId { get; set; }

    [JsonPropertyName("elementType")]
    public string ElementType { get; set; } = default!;

    [JsonPropertyName("showTips")]
    public bool ShowTips { get; set; }

    [JsonPropertyName("minimapScale")]
    public float MinimapScale { get; set; }

    [JsonPropertyName("AreaID2")]
    public int? AreaID2 { get; set; }

    [JsonPropertyName("terrainType")]
    public string TerrainType { get; set; } = default!;

    [JsonPropertyName("AreaDefaultLock")]
    public bool? AreaDefaultLock { get; set; }
}