namespace Snap.Data.Mapper.Model;
public class AchievementGoalExcelConfigData : DataModel
{
    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public TextMapHash NameTextMapHash { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("finishRewardId")]
    public int? FinishRewardId { get; set; }
}
