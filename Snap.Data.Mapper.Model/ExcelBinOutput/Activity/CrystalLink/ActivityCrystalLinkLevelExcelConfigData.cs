namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.CrystalLink;

public class ActivityCrystalLinkLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("trialAvatarList")]
    public IList<int> TrialAvatarList { get; set; } = default!;

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("DKDAINLMHJK")]
    public IList<int> DKDAINLMHJK { get; set; } = default!;

    [JsonPropertyName("MKJCODMPDGK")]
    public IList<int> MKJCODMPDGK { get; set; } = default!;

    [JsonPropertyName("levelTitleTextMapHash")]
    public Text LevelTitleTextMapHash { get; set; }

    [JsonPropertyName("levelDescTextMapHash")]
    public Text LevelDescTextMapHash { get; set; }

    [JsonPropertyName("LCBFCIBGDNM")]
    public IList<HPGLJGCCMFFODJBMAKLICP<string>> LCBFCIBGDNM { get; set; } = default!;

    [JsonPropertyName("MENBLJCNMBK")]
    public IList<HPGLJGCCMFFODJBMAKLICP<int>> MENBLJCNMBK { get; set; } = default!;

    [JsonPropertyName("scoreLevelList")]
    public IList<int> ScoreLevelList { get; set; } = default!;

    [JsonPropertyName("DCDGEGGDELE")]
    public int DCDGEGGDELE { get; set; }

    [JsonPropertyName("JOAJNBHLNFL")]
    public int JOAJNBHLNFL { get; set; }
}
