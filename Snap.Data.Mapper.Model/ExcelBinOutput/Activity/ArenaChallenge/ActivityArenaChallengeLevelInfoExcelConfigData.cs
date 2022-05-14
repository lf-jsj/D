namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ArenaChallenge;

public class ActivityArenaChallengeLevelInfoExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    [PrimaryKey]
    public int ID { get; set; }

    [JsonPropertyName("scheduleId")]
    [ForeignKey]
    public int ScheduleId { get; set; }

    [JsonPropertyName("levelId")]
    [ForeignKey]
    public int LevelId { get; set; }

    [JsonPropertyName("levelNameTextMapHash")]
    public Text LevelNameTextMapHash { get; set; }

    //TODO: link up monster
    [JsonPropertyName("monsterPreviewId")]
    [ForeignKey]
    public int MonsterPreviewId { get; set; }

    //TODO: link up monster
    [JsonPropertyName("monsterConfig")]
    [ForeignKey]
    public string MonsterConfig { get; set; } = default!;

    [JsonPropertyName("levelDescTextMapHash")]
    public Text LevelDescTextMapHash { get; set; }

    [JsonPropertyName("KICEBBCKKPI")]
    public string KICEBBCKKPI { get; set; } = string.Empty;

    [JsonPropertyName("CCEPHHIHMKI")]
    [ForeignKey]
    public int CCEPHHIHMKI { get; set; }

    [JsonPropertyName("MDFFPBEGJOH")]
    [ForeignKey]
    public string MDFFPBEGJOH { get; set; } = default!;

    [JsonPropertyName("CAMDGAAIKAA")]
    public Text CAMDGAAIKAA { get; set; }

    [JsonPropertyName("MPPHKDDAAPG")]
    public string MPPHKDDAAPG { get; set; } = string.Empty;

    [JsonPropertyName("levelDetailDescTextMapHash")]
    public Text LevelDetailDescTextMapHash { get; set; }

    //TODO: link up challenge id
    [JsonPropertyName("challengeIdList")]
    public IList<int> ChallengeIdList { get; set; } = default!;
}
