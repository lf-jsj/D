namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("displayNameTextMapHash")]
    public Text DisplayNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("involveType")]
    public string InvolveType { get; set; } = default!;

    [JsonPropertyName("showLevel")]
    public int ShowLevel { get; set; }

    [JsonPropertyName("limitLevel")]
    public int LimitLevel { get; set; }

    [JsonPropertyName("levelRevise")]
    public int LevelRevise { get; set; }

    [JsonPropertyName("passCond")]
    public int PassCond { get; set; }

    [JsonPropertyName("reviveMaxCount")]
    public int ReviveMaxCount { get; set; }

    [JsonPropertyName("dayEnterCount")]
    public int DayEnterCount { get; set; }

    [JsonPropertyName("OAHEDOJMNDO")]
    public IList<DataObject> OAHEDOJMNDO { get; set; } = default!;

    [JsonPropertyName("passRewardPreviewID")]
    public int PassRewardPreviewID { get; set; }

    [JsonPropertyName("settleCountdownTime")]
    public int SettleCountdownTime { get; set; }

    [JsonPropertyName("failSettleCountdownTime")]
    public int FailSettleCountdownTime { get; set; }

    [JsonPropertyName("quitSettleCountdownTime")]
    public int QuitSettleCountdownTime { get; set; }

    [JsonPropertyName("settleShows")]
    public IList<string> SettleShows { get; set; } = default!;

    [JsonPropertyName("forbiddenRestart")]
    public bool ForbiddenRestart { get; set; }

    [JsonPropertyName("settleUIType")]
    public string SettleUIType { get; set; } = default!;

    [JsonPropertyName("recommendElementTypes")]
    public IList<string> RecommendElementTypes { get; set; } = default!;

    [JsonPropertyName("levelConfigMap")]
    public IDictionary<string,int> LevelConfigMap { get; set; } = default!;

    [JsonPropertyName("enterCostItems")]
    public IList<int> EnterCostItems { get; set; } = default!;

    [JsonPropertyName("MGGEAPMHECN")]
    public Text MGGEAPMHECN { get; set; } = default!;

    [JsonPropertyName("cityID")]
    public int CityID { get; set; }

    [JsonPropertyName("entryPicPath")]
    public string EntryPicPath { get; set; } = default!;

    [JsonPropertyName("stateType")]
    public string StateType { get; set; } = default!;

    [JsonPropertyName("LHDOFAEMFBG")]
    public string LHDOFAEMFBG { get; set; } = default!;

    [JsonPropertyName("OMPDIGHPMHO")]
    public string OMPDIGHPMHO { get; set; } = default!;

    [JsonPropertyName("avatarLimitType")]
    public int? AvatarLimitType { get; set; }

    [JsonPropertyName("isDynamicLevel")]
    public bool? IsDynamicLevel { get; set; }

    [JsonPropertyName("serialId")]
    public int? SerialId { get; set; }

    [JsonPropertyName("passJumpDungeon")]
    public int? PassJumpDungeon { get; set; }

    [JsonPropertyName("dontShowPushTips")]
    public bool? DontShowPushTips { get; set; }

    [JsonPropertyName("playType")]
    public string PlayType { get; set; } = default!;

    [JsonPropertyName("eventInterval")]
    public int? EventInterval { get; set; }

    [JsonPropertyName("firstPassRewardPreviewID")]
    public int? FirstPassRewardPreviewID { get; set; }

    [JsonPropertyName("reviveIntervalTime")]
    public int? ReviveIntervalTime { get; set; }

    [JsonPropertyName("statueCostID")]
    public int? StatueCostID { get; set; }

    [JsonPropertyName("statueCostCount")]
    public int? StatueCostCount { get; set; }

    [JsonPropertyName("statueDrop")]
    public int? StatueDrop { get; set; }
}
