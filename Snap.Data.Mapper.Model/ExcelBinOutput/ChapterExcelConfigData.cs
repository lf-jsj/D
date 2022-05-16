namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ChapterExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("beginQuestId")]
    public int BeginQuestId { get; set; }

    [JsonPropertyName("endQuestId")]
    public int EndQuestId { get; set; }

    [JsonPropertyName("needBeginTimeStr")]
    public string NeedBeginTimeStr { get; set; } = default!;

    [JsonPropertyName("chapterNumTextMapHash")]
    public Text ChapterNumTextMapHash { get; set; }

    [JsonPropertyName("chapterTitleTextMapHash")]
    public Text ChapterTitleTextMapHash { get; set; }

    [JsonPropertyName("chapterIcon")]
    public string ChapterIcon { get; set; } = default!;

    [JsonPropertyName("chapterImageHashSuffix")]
    public Text ChapterImageHashSuffix { get; set; }

    [JsonPropertyName("chapterImageHashPre")]
    public int ChapterImageHashPre { get; set; }

    [JsonPropertyName("chapterImageTitleTextMapHash")]
    public Text ChapterImageTitleTextMapHash { get; set; }

    [JsonPropertyName("chapterSerialNumberIcon")]
    public string ChapterSerialNumberIcon { get; set; } = default!;

    [JsonPropertyName("needPlayerLevel")]
    public int? NeedPlayerLevel { get; set; }

    [JsonPropertyName("activityId")]
    public int? ActivityId { get; set; }

    [JsonPropertyName("inActivityNeedPlayerLevel")]
    public int? InActivityNeedPlayerLevel { get; set; }
}
