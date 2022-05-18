namespace Snap.Data.Mapper.Model.ExcelBinOutput.PushTip;

public class PushTipsConfigData : DataObject
{
    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("subtitleTextMapHash")]
    public Text SubtitleTextMapHash { get; set; }

    [JsonPropertyName("pushTipsType")]
    public string PushTipsType { get; set; } = default!;

    [JsonPropertyName("showIcon")]
    public string ShowIcon { get; set; } = default!;

    [JsonPropertyName("tabIcon")]
    public string TabIcon { get; set; } = default!;

    [JsonPropertyName("tutorialId")]
    public int TutorialId { get; set; }

    [JsonPropertyName("codexType")]
    public string CodexType { get; set; } = default!;

    [JsonPropertyName("showImmediately")]
    public bool? ShowImmediately { get; set; }

    [JsonPropertyName("groupId")]
    public int? GroupId { get; set; }
}