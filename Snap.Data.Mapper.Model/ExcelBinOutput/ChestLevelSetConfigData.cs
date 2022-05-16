namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ChestLevelSetConfigData : DataObject
{
    [JsonPropertyName("zoneMinLevel")]
    public int ZoneMinLevel { get; set; }

    [JsonPropertyName("chestLevel")]
    public int ChestLevel { get; set; }
}
