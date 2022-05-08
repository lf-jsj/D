namespace Snap.Data.Mapper.Model.Achievement;
public class AchievementGoalExcelConfigData : DataModel
{
    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public MappedText NameTextMapHash { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("finishRewardId")]
    public int? FinishRewardId { get; set; }
}
