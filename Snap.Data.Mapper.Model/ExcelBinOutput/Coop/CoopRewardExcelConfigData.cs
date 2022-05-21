using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;

public class CoopRewardExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("rewardCond")]
    public IList<CondTypeArgs> RewardCond { get; set; } = default!;

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("sortId")]
    public int SortId { get; set; }

    [JsonPropertyName("condTipTextMapHash")]
    public Text CondTipTextMapHash { get; set; }

    [JsonPropertyName("condTipDesTextMapHash")]
    public Text CondTipDesTextMapHash { get; set; }
}