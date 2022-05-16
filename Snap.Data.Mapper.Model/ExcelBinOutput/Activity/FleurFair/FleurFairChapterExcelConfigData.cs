namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FleurFair;

public class FleurFairChapterExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("mainQuest")]
    public int MainQuest { get; set; }

    [JsonPropertyName("miniQuest")]
    public IList<int> MiniQuest { get; set; } = default!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("preQuest")]
    public int? PreQuest { get; set; }
}
