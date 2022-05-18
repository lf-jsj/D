namespace Snap.Data.Mapper.Model.ExcelBinOutput.MpPlay;

public class RewardVec : DataObject
{
    [JsonPropertyName("dropID")]
    public int DropID { get; set; }

    [JsonPropertyName("rewardPreview")]
    public int RewardPreview { get; set; }
}
