using Snap.Data.Mapper.Converter.ObjectModel;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
public class AchievementGoalExcelConfigData : DataObject
{
    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    [PrimaryKey]
    public int? Id { get; set; }

    [JsonPropertyName("finishRewardId")]
    [ForeignKey]
    public int? FinishRewardId { get; set; }
}
