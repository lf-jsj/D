using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reward;
public class RewardExcelConfigData : IndexableDataObject
{
    [JsonPropertyName("rewardId")]
    [PrimaryKey]
    public int RewardId { get; set; }

    [JsonPropertyName("rewardItemList")]
    public IList<ItemIdItemCount> RewardItemList { get; set; } = default!;

    [JsonPropertyName("scoin")]
    public int? Scoin { get; set; }

    [JsonPropertyName("playerExp")]
    public int? PlayerExp { get; set; }

    [JsonPropertyName("hcoin")]
    public int? Hcoin { get; set; }

    public override int GetIndex()
    {
        return RewardId;
    }
}