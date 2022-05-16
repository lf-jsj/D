namespace Snap.Data.Mapper.Model.ExcelBinOutput.Daily;

public class DailyTaskLevelExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("minPlayerLevel")]
    public int MinPlayerLevel { get; set; }

    [JsonPropertyName("maxPlayerLevel")]
    public int MaxPlayerLevel { get; set; }

    [JsonPropertyName("scoreDropId")]
    public int ScoreDropId { get; set; }

    [JsonPropertyName("scorePreviewRewardId")]
    public int ScorePreviewRewardId { get; set; }

    [JsonPropertyName("groupReviseLevel")]
    public int? GroupReviseLevel { get; set; }
}