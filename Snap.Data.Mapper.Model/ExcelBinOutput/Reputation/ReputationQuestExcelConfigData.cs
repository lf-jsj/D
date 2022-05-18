namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;

public class ReputationQuestExcelConfigData : DataObject
{
    [JsonPropertyName("ParentQuestId")]
    public int ParentQuestId { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }
}