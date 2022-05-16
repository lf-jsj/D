namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabLevelExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("stageID")]
    public int StageID { get; set; }

    [JsonPropertyName("buffNum")]
    public int BuffNum { get; set; }

    [JsonPropertyName("pointNameTextMapHash")]
    public Text PointNameTextMapHash { get; set; }

    [JsonPropertyName("campNameTextMapHash")]
    public Text CampNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("groupID")]
    public int GroupID { get; set; }
}
