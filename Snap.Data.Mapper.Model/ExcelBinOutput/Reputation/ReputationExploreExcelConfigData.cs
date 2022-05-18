namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;

public class ReputationExploreExcelConfigData : DataObject
{
    [JsonPropertyName("exploreId")]
    public int ExploreId { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("exploreProgress")]
    public int ExploreProgress { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("conditionTextTextMapHash")]
    public Text ConditionTextTextMapHash { get; set; }
}