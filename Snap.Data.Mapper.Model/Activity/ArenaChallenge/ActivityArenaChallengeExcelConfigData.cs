namespace Snap.Data.Mapper.Model.Activity.ArenaChallenge;

public class ActivityArenaChallengeExcelConfigData
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("arenaChallengeId")]
    public int ArenaChallengeId { get; set; }

    [JsonPropertyName("arenaChallengeLevel")]
    public int ArenaChallengeLevel { get; set; }

    [JsonPropertyName("watcherId")]
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