namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BounceConjuring;

public class BounceConjuringPreviewExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("activityStayTime")]
    public int ActivityStayTime { get; set; }

    [JsonPropertyName("preQuestId")]
    public int PreQuestId { get; set; }

    [JsonPropertyName("DBJCFMOIHMN")]
    public int DBJCFMOIHMN { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("matchID")]
    public int MatchID { get; set; }
}