namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class TowerSkipFloorExcelConfigData : DataObject
{
    [JsonPropertyName("prevLevelIndex")]
    public int PrevLevelIndex { get; set; }

    [JsonPropertyName("curLevelIndex")]
    public int? CurLevelIndex { get; set; }
}
