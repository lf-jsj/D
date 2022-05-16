namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class TimeRewardVec : DataObject
{
    [JsonPropertyName("htime")]
    public int Htime { get; set; }

    [JsonPropertyName("rewardDropId")]
    public int RewardDropId { get; set; }

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }
}
