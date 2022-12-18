namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FleurFair;

public class FleurFairMiniGameExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("miniGameType")]
    public string MiniGameType { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("rewardRankLowTextMapHash")]
    public Text RewardRankLowTextMapHash { get; set; }

    [JsonPropertyName("rewardRankMiddleTextMapHash")]
    public Text RewardRankMiddleTextMapHash { get; set; }

    [JsonPropertyName("rewardRankHighTextMapHash")]
    public Text RewardRankHighTextMapHash { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("avatarIdList")]
    public IList<int> AvatarIdList { get; set; } = default!;

    [JsonPropertyName("avatarScore")]
    public IList<int> AvatarScore { get; set; } = default!;

    [JsonPropertyName("tipsIdList")]
    public IList<int> TipsIdList { get; set; } = default!;

    [JsonPropertyName("tipsDescTextMapHash")]
    public Text TipsDescTextMapHash { get; set; }

    [JsonPropertyName("pos")]
    public IList<float> Pos { get; set; } = default!;
}
