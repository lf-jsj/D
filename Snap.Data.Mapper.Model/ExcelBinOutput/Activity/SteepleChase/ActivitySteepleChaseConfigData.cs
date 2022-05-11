namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SteepleChase;

public class ActivitySteepleChaseConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("levelTitleTextMapHash")]
    public Text LevelTitleTextMapHash { get; set; }

    [JsonPropertyName("levelDescTextMapHash")]
    public Text LevelDescTextMapHash { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }
}
