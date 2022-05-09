namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ArenaChallenge;

public class ActivityArenaChallengePreviewExcelConfigData : DataObject
{
    //TODO: link up id
    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    //TODO: link up id
    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("centerPosList")]
    [DataArray(Length = 3)]
    public IList<double> CenterPosList { get; set; } = default!;

    //TODO: link up id
    [JsonPropertyName("guideQuestId1")]
    public int GuideQuestId1 { get; set; }

    [JsonPropertyName("AEFANIAOIKL")]
    public int? AEFANIAOIKL { get; set; }

    [JsonPropertyName("MAALMJFAHCD")]
    public int? MAALMJFAHCD { get; set; }
}
