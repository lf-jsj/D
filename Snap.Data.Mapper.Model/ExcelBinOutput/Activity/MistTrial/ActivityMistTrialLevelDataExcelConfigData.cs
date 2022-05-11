namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MistTrial;

public class ActivityMistTrialLevelDataExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("levelTitleTextMapHash")]
    public Text LevelTitleTextMapHash { get; set; }

    [JsonPropertyName("levelDescTextMapHash")]
    public Text LevelDescTextMapHash { get; set; }

    [JsonPropertyName("monsterPreviewIdList")]
    public IList<int> MonsterPreviewIdList { get; set; } = default!;

    [JsonPropertyName("OODOFCGHEND")]
    public IList<int> OODOFCGHEND { get; set; } = default!;

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("challengeMissionWatcherList")]
    public IList<int> ChallengeMissionWatcherList { get; set; } = default!;

    [JsonPropertyName("statisticsIdList")]
    public IList<int> StatisticsIdList { get; set; } = default!;

    [JsonPropertyName("bgIconHashSuffix")]
    public HashSuffix BgIconHashSuffix { get; set; }

    [JsonPropertyName("bgIconHashPre")]
    public HashPre BgIconHashPre { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("dungeonFactorIdList")]
    public IList<int> DungeonFactorIdList { get; set; } = default!;

    [JsonPropertyName("failTips")]
    public IList<string> FailTips { get; set; } = default!;

    [JsonPropertyName("GJJFOBDBGBG")]
    public IList<int> GJJFOBDBGBG { get; set; } = default!;

    [JsonPropertyName("MFHOKIBKJFP")]
    public string MFHOKIBKJFP { get; set; } = default!;

    [JsonPropertyName("NEEPLANMAJO")]
    public IList<int> NEEPLANMAJO { get; set; } = default!;

    [JsonPropertyName("NFLEMKHPLJI")]
    public IList<int> NFLEMKHPLJI { get; set; } = default!;
}
