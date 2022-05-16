namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FleurFair;

public class FleurFairPreviewExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("activityStayTime")]
    public int ActivityStayTime { get; set; }

    [JsonPropertyName("unlockQuestID")]
    public int UnlockQuestID { get; set; }

    [JsonPropertyName("unlockPlayerLevel")]
    public int UnlockPlayerLevel { get; set; }

    [JsonPropertyName("gameplayPreQuest")]
    public int GameplayPreQuest { get; set; }

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }
}
