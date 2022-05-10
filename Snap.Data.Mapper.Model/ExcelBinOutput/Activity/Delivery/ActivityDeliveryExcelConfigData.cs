namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Delivery;

public class ActivityDeliveryExcelConfigData : DataObject
{
    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("dailyConfigIdList")]
    public IList<int> DailyConfigIdList { get; set; } = default!;

    [JsonPropertyName("needPlayerLevel")]
    public int NeedPlayerLevel { get; set; }
}