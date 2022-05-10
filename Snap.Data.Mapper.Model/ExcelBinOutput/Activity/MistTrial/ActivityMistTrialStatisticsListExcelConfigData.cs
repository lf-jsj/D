namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MistTrial;

public class ActivityMistTrialStatisticsListExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("statName")]
    public string StatName { get; set; } = string.Empty;

    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;
}
