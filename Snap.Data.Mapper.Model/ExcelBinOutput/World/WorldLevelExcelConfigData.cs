namespace Snap.Data.Mapper.Model.ExcelBinOutput.World;

public class WorldLevelExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("monsterLevel")]
    public int MonsterLevel { get; set; }
}