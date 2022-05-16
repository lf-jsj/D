namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabDungeonExcelConfigData : DataObject
{
    [JsonPropertyName("stageID")]
    public int StageID { get; set; }

    [JsonPropertyName("dungeonID")]
    public int DungeonID { get; set; }

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("pointID")]
    public int PointID { get; set; }

    [JsonPropertyName("pos")]
    public IList<DataObject> Pos { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}
