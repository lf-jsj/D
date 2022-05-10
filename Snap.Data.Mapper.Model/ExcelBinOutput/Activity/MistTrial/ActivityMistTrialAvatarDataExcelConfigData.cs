namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MistTrial;
public class ActivityMistTrialAvatarDataExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("trialAvatarId")]
    public int TrialAvatarId { get; set; }
}
