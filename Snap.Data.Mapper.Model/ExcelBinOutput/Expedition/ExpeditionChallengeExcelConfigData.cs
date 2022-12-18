namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class ExpeditionChallengeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("rewardChallengeIndex")]
    public int RewardChallengeIndex { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("challengeNameTextMapHash")]
    public Text ChallengeNameTextMapHash { get; set; }

    [JsonPropertyName("challengeDescTextMapHash")]
    public Text ChallengeDescTextMapHash { get; set; }

    [JsonPropertyName("superElement")]
    public string SuperElement { get; set; } = default!;

    [JsonPropertyName("centerPosList")]
    public IList<float> CenterPosList { get; set; } = default!;

    [JsonPropertyName("centerRadius")]
    public int CenterRadius { get; set; }

    [JsonPropertyName("unlockTime")]
    public int? UnlockTime { get; set; }
}