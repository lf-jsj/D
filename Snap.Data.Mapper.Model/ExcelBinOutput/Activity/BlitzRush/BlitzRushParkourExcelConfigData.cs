namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BlitzRush;

public class BlitzRushParkourExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;
}
