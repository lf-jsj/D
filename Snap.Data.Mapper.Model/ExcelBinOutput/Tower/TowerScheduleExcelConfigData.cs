namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class TowerScheduleExcelConfigData : DataObject
{
    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("entranceFloorId")]
    public IList<int> EntranceFloorId { get; set; } = default!;

    [JsonPropertyName("schedules")]
    public IList<Schedule> Schedules { get; set; } = default!;

    [JsonPropertyName("closeTime")]
    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime CloseTime { get; set; }

    [JsonPropertyName("OKPPDCCEILD")]
    public int OKPPDCCEILD { get; set; }

    [JsonPropertyName("scheduleRewards")]
    public IList<ScheduleReward> ScheduleRewards { get; set; } = default!;

    [JsonPropertyName("monthlyLevelConfigId")]
    public int MonthlyLevelConfigId { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("buffnameTextMapHash")]
    public Text BuffnameTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;
}