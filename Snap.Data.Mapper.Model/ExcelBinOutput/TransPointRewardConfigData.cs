namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class TransPointRewardConfigData : DataObject
{
    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("pointId")]
    public int PointId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("NBCACBDPIKE")]
    public IList<DataObject> NBCACBDPIKE { get; set; } = default!;

    [JsonPropertyName("groupIdVec")]
    public IList<int> GroupIdVec { get; set; } = default!;
}
