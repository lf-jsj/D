namespace Snap.Data.Mapper.Model.ExcelBinOutput.Group;

public class GroupLinksBundleRewardExcelConfigData : DataObject
{
    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("rewardPreviewID")]
    public int RewardPreviewID { get; set; }

    [JsonPropertyName("dropID")]
    public int? DropID { get; set; }
}
