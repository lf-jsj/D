namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reminder;

public class ReminderIndexExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("reminderID")]
    public IList<int> ReminderID { get; set; } = default!;

    [JsonPropertyName("showType")]
    public string ShowType { get; set; } = default!;
}