namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class QuestCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("parentQuestId")]
    public int ParentQuestId { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool IsDisuse { get; set; }
}