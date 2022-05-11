namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SummerTime;

public class ActivitySummerTimeRacePreviewExcelConfigData : DataObject
{

    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("levelDescTextMapHash")]
    public Text LevelDescTextMapHash { get; set; }
}
