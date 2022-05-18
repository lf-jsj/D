namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reward;
public class RewardExcelConfigData : DataObject
{
    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("rewardItemList")]
    public IList<RewardItem> RewardItemList { get; set; } = default!;

    [JsonPropertyName("scoin")]
    public int? Scoin { get; set; }

    [JsonPropertyName("playerExp")]
    public int? PlayerExp { get; set; }

    [JsonPropertyName("hcoin")]
    public int? Hcoin { get; set; }
}
