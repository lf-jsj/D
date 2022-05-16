namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class ExpeditionPathExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("difficultyId")]
    public int DifficultyId { get; set; }

    [JsonPropertyName("superElement")]
    public string SuperElement { get; set; } = default!;

    [JsonPropertyName("basicRewardId")]
    public int BasicRewardId { get; set; }

    [JsonPropertyName("bonusRewardId")]
    public int BonusRewardId { get; set; }

    [JsonPropertyName("pathNameTextMapHash")]
    public Text PathNameTextMapHash { get; set; }

    [JsonPropertyName("pathDescTextMapHash")]
    public Text PathDescTextMapHash { get; set; }

    [JsonPropertyName("GGLCFONEMDK")]
    public IList<int> GGLCFONEMDK { get; set; } = default!;

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }
}