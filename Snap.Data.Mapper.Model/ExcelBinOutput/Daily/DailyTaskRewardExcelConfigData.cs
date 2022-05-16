namespace Snap.Data.Mapper.Model.ExcelBinOutput.Daily;

public class DailyTaskRewardExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("dropVec")]
    public IList<DropVec> DropVec { get; set; } = default!;
}
