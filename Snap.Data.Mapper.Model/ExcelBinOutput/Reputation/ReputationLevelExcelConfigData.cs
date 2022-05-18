namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;

public class ReputationLevelExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("levelNameTextMapHash")]
    public Text LevelNameTextMapHash { get; set; }

    [JsonPropertyName("nextLevelExp")]
    public int NextLevelExp { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("requestGroupId")]
    public int RequestGroupId { get; set; }

    [JsonPropertyName("requestNum")]
    public int RequestNum { get; set; }

    [JsonPropertyName("requestAcceptNum")]
    public int RequestAcceptNum { get; set; }

    [JsonPropertyName("functionId")]
    public int? FunctionId { get; set; }
}