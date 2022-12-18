namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salesman;

public class ActivitySalesmanExcelConfigData : DataObject
{
    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("dailyConfigIdList")]
    public IList<int> DailyConfigIdList { get; set; } = default!;

    [JsonPropertyName("normalRewardIdList")]
    public IList<int> NormalRewardIdList { get; set; } = default!;

    [JsonPropertyName("specialRewardIdList")]
    public IList<int> SpecialRewardIdList { get; set; } = default!;

    [JsonPropertyName("specialProbList")]
    public IList<float> SpecialProbList { get; set; } = default!;

    [JsonPropertyName("specialReward")]
    public SpecialReward SpecialReward { get; set; } = default!;
}
