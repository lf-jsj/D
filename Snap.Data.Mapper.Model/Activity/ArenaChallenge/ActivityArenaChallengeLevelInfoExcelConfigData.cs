namespace Snap.Data.Mapper.Model.Activity.ArenaChallenge;

public class ActivityArenaChallengeLevelInfoExcelConfigData
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("levelNameTextMapHash")]
    public MappedText LevelNameTextMapHash { get; set; }

    //TODO: link up monster
    [JsonPropertyName("monsterPreviewId")]
    public int MonsterPreviewId { get; set; }

    //TODO: link up monster
    [JsonPropertyName("monsterConfig")]
    public string MonsterConfig { get; set; } = string.Empty;

    [JsonPropertyName("levelDescTextMapHash")]
    public MappedText LevelDescTextMapHash { get; set; }

    [JsonPropertyName("KICEBBCKKPI")]
    public string KICEBBCKKPI { get; set; } = string.Empty;

    [JsonPropertyName("CCEPHHIHMKI")]
    public int CCEPHHIHMKI { get; set; }

    [JsonPropertyName("MDFFPBEGJOH")]
    public string MDFFPBEGJOH { get; set; } = string.Empty;

    [JsonPropertyName("CAMDGAAIKAA")]
    public MappedText CAMDGAAIKAA { get; set; }

    [JsonPropertyName("MPPHKDDAAPG")]
    public string MPPHKDDAAPG { get; set; } = string.Empty;

    [JsonPropertyName("levelDetailDescTextMapHash")]
    public MappedText LevelDetailDescTextMapHash { get; set; }

    //TODO: link up challenge id
    [JsonPropertyName("challengeIdList")]
    public IList<int> ChallengeIdList { get; set; } = default!;
}
