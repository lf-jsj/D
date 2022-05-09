namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ArenaChallenge;

public class ActivityArenaChallengeExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    [PrimaryKey]
    public int ID { get; set; }

    [JsonPropertyName("scheduleId")]
    [ForeignKey]
    public int ScheduleId { get; set; }

    [JsonPropertyName("arenaChallengeId")]
    [ForeignKey]
    public int ArenaChallengeId { get; set; }

    [JsonPropertyName("arenaChallengeLevel")]
    public int ArenaChallengeLevel { get; set; }

    [JsonPropertyName("watcherId")]
    [ForeignKey]
    public int WatcherId { get; set; }

    //TODO: handle wierd hash result
    [JsonPropertyName("challengeTargetTextMapHash")]
    public MappedText ChallengeTargetTextMapHash { get; set; }

    //TODO: handle wierd hash result
    [JsonPropertyName("challengeTarget1TextMapHash")]
    public MappedText ChallengeTarget1TextMapHash { get; set; }

    //TODO: handle wierd hash result
    [JsonPropertyName("challengeTarget2TextMapHash")]
    public MappedText ChallengeTarget2TextMapHash { get; set; }

    [JsonPropertyName("ILEDPNFPAAK")]
    public bool? ILEDPNFPAAK { get; set; }
}