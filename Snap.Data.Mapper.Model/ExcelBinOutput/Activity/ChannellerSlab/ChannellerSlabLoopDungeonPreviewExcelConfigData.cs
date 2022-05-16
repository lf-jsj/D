namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabLoopDungeonPreviewExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("entryDescTextMapHash")]
    public Text EntryDescTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("pointID")]
    public int PointID { get; set; }
}
