namespace Snap.Data.Mapper.Model.ExcelBinOutput.BattlePass;

public class BattlePassMissionExcelConfigData : DataObject
{
    [JsonPropertyName("addPoint")]
    public int AddPoint { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("guide")]
    public Guide Guide { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("refreshType")]
    public string RefreshType { get; set; } = default!;

    [JsonPropertyName("scheduleId")]
    public int? ScheduleId { get; set; }

    [JsonPropertyName("activityId")]
    public int? ActivityId { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    [JsonPropertyName("isForce")]
    public bool? IsForce { get; set; }
}
