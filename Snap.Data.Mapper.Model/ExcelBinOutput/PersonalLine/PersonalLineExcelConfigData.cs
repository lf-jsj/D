namespace Snap.Data.Mapper.Model.ExcelBinOutput.PersonalLine;

public class PersonalLineExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("startQuestId")]
    public int StartQuestId { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("preQuestId")]
    public IList<int> PreQuestId { get; set; } = default!;

    [JsonPropertyName("startTime")]
    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime StartTime { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("sortOrder")]
    public int SortOrder { get; set; }
}