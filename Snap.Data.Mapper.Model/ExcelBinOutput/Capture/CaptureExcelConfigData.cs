namespace Snap.Data.Mapper.Model.ExcelBinOutput.Capture;

public class CaptureExcelConfigData : DataObject
{
    [JsonPropertyName("monsterID")]
    public int MonsterID { get; set; }

    [JsonPropertyName("BLFLMKOEFMK")]
    public IList<BLFLMKOEFMK> BLFLMKOEFMK { get; set; } = default!;
}
