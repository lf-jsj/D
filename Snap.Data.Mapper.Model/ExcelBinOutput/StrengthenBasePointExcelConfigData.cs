namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class StrengthenBasePointExcelConfigData : DataObject
{
    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("dungeonType")]
    public string DungeonType { get; set; } = default!;
}