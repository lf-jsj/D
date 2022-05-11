namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SummerTime;
public class ActivitySummerTimeExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("unlockQuestID")]
    public int UnlockQuestID { get; set; }

    [JsonPropertyName("contentDuration")]
    public int ContentDuration { get; set; }

    [JsonPropertyName("unlockPlayerLevel")]
    public int UnlockPlayerLevel { get; set; }

    [JsonPropertyName("LCHKEMOANBM")]
    public int LCHKEMOANBM { get; set; }

    [JsonPropertyName("FDGGAJNIGDA")]
    public IList<int> FDGGAJNIGDA { get; set; } = default!;

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }

    [JsonPropertyName("questIdList")]
    public IList<int> QuestIdList { get; set; } = default!;
}
