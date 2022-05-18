namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SeaLampSection;
public class SeaLampSectionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sectionId")]
    public int SectionId { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("mainQuestId")]
    public int MainQuestId { get; set; }

    [JsonPropertyName("miniQuestId")]
    public IList<int> MiniQuestId { get; set; } = default!;

    [JsonPropertyName("watcherIdVec")]
    public IList<int> WatcherIdVec { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }
}
