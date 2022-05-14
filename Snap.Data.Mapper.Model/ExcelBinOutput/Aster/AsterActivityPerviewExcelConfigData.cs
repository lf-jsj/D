namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;
public class AsterActivityPerviewExcelConfigData : DataObject
{
    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("unlockLevel")]
    public int UnlockLevel { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;

    [JsonPropertyName("specialRewardId")]
    public int SpecialRewardId { get; set; }

    [JsonPropertyName("activityStayTime")]
    public int ActivityStayTime { get; set; }

    [JsonPropertyName("perfabChangeQuestId")]
    public int PerfabChangeQuestId { get; set; }
}
