namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeDarkChallengeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("challengeId")]
    public int ChallengeId { get; set; }

    [JsonPropertyName("rewardId")]
    public IList<int> RewardId { get; set; } = default!;

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }
}