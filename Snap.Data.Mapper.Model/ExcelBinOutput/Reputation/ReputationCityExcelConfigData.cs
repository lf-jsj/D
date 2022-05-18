namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;
public class ReputationCityExcelConfigData : DataObject
{
    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("exploreAreaVec")]
    public IList<int> ExploreAreaVec { get; set; } = default!;

    [JsonPropertyName("virtualItemId")]
    public int VirtualItemId { get; set; }

    [JsonPropertyName("openState")]
    public string OpenState { get; set; } = default!;

    [JsonPropertyName("bgIconPath")]
    public string BgIconPath { get; set; } = default!;

    [JsonPropertyName("bgEffectPath")]
    public string BgEffectPath { get; set; } = default!;

    [JsonPropertyName("explainTitleTextMapHash")]
    public Text ExplainTitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("rewardItemId")]
    public int RewardItemId { get; set; }

    [JsonPropertyName("rewardItemDescTextMapHash")]
    public Text RewardItemDescTextMapHash { get; set; }

    [JsonPropertyName("rewardItemIcon")]
    public string RewardItemIcon { get; set; } = default!;

    [JsonPropertyName("rewardBgIcon")]
    public string RewardBgIcon { get; set; } = default!;

    [JsonPropertyName("cityIcon")]
    public string CityIcon { get; set; } = default!;
}
