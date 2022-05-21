namespace Snap.Data.Mapper.Model.Common;

public class DropIDRewardPreview : DataObject
{
    [JsonPropertyName("dropID")]
    public int DropID { get; set; }

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }
}
