namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonMapAreaExcelConfigData : DataObject
{
    [JsonPropertyName("dungeonID")]
    public int DungeonID { get; set; }

    [JsonPropertyName("areaID")]
    public int AreaID { get; set; }
}
