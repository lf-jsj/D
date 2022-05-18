namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityScoreRewardExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("activityScoreTipsTextMapHash")]
    public Text ActivityScoreTipsTextMapHash { get; set; }

    [JsonPropertyName("activityScoreExtraTipsTextMapHash")]
    public Text ActivityScoreExtraTipsTextMapHash { get; set; }
}