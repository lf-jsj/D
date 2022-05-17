namespace Snap.Data.Mapper.Model.ExcelBinOutput.Hunting;

public class HuntingClueTextExcelConfigData : DataObject
{
    [JsonPropertyName("clueTextId")]
    public int ClueTextId { get; set; }

    [JsonPropertyName("reminderIdList")]
    public IList<int> ReminderIdList { get; set; } = default!;
}