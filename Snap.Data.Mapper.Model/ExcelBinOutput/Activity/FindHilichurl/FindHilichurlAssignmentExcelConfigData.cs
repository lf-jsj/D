namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FindHilichurl;
public class FindHilichurlAssignmentExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("dayIndex")]
    public int DayIndex { get; set; }

    [JsonPropertyName("questID")]
    public int QuestID { get; set; }

    [JsonPropertyName("keyWord")]
    public string KeyWord { get; set; } = default!;

    [JsonPropertyName("hintSubQuestId")]
    public int HintSubQuestId { get; set; }

    [JsonPropertyName("assignmentType")]
    public string AssignmentType { get; set; } = default!;
}
