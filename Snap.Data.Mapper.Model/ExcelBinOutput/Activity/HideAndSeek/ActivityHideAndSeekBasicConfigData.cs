namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.HideAndSeek;

public class ActivityHideAndSeekBasicConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityID")]
    public int ActivityID { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("pushTipsID")]
    public int PushTipsID { get; set; }

    [JsonPropertyName("rewardPreviewID")]
    public int RewardPreviewID { get; set; }

    [JsonPropertyName("oneTimeRewardPreviewID")]
    public int OneTimeRewardPreviewID { get; set; }

    [JsonPropertyName("unlockQuestID")]
    public int UnlockQuestID { get; set; }

    [JsonPropertyName("matchID")]
    public int MatchID { get; set; }

    [JsonPropertyName("draftID")]
    public int DraftID { get; set; }

    [JsonPropertyName("scoreUnlockList")]
    public IList<int> ScoreUnlockList { get; set; } = default!;

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;

    [JsonPropertyName("skillList")]
    public IList<int> SkillList { get; set; } = default!;

    [JsonPropertyName("mapList")]
    public IList<int> MapList { get; set; } = default!;

    [JsonPropertyName("chanllengeList")]
    public IList<int> ChanllengeList { get; set; } = default!;

    [JsonPropertyName("scoreItemID")]
    public int ScoreItemID { get; set; }
}