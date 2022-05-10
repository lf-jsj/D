namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MistTrial;

public class ActivityMistTrialWatcherListDataExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("challengeWatcherId")]
    public int ChallengeWatcherId { get; set; }

    [JsonPropertyName("dungeonShowContentType")]
    public string DungeonShowContentType { get; set; } = string.Empty;

    [JsonPropertyName("showParam")]
    public IList<string> ShowParam { get; set; } = default!;

    [JsonPropertyName("progressFormatTextMapHash")]
    public Text ProgressFormatTextMapHash { get; set; }

    [JsonPropertyName("JLEJLPFDKFH")]
    public Text JLEJLPFDKFH { get; set; }

    [JsonPropertyName("BMIAIKCJCMJ")]
    public bool? BMIAIKCJCMJ { get; set; }
}