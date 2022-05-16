namespace Snap.Data.Mapper.Model.ExcelBinOutput.Bored;
public class BoredActionPriorityExcelConfigData : DataObject
{
    [JsonPropertyName("actionType")]
    public string ActionType { get; set; } = default!;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
