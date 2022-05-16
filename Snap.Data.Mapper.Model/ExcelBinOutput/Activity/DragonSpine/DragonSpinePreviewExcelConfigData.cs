namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.DragonSpine;

public class DragonSpinePreviewExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("preQuestId")]
    public int PreQuestId { get; set; }

    [JsonPropertyName("unlockLevel")]
    public int UnlockLevel { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("contentDuration")]
    public int ContentDuration { get; set; }

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("questIdList")]
    public IList<int> QuestIdList { get; set; } = default!;
}
