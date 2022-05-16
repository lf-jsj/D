namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabPreviewExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("activityStayTime")]
    public int ActivityStayTime { get; set; }

    [JsonPropertyName("unlockQuestID")]
    public int UnlockQuestID { get; set; }

    [JsonPropertyName("slabQuestID")]
    public int SlabQuestID { get; set; }

    [JsonPropertyName("unlockPlayerLevel")]
    public int UnlockPlayerLevel { get; set; }

    [JsonPropertyName("levelRewardGadgetID")]
    public int LevelRewardGadgetID { get; set; }

    [JsonPropertyName("isMaskAvatarReward")]
    public bool? IsMaskAvatarReward { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int? RewardPreviewId { get; set; }
}