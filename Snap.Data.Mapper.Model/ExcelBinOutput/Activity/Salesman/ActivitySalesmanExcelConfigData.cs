namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salesman;

public class SpecialReward : DataObject
{
    [JsonPropertyName("obtainParam")]
    public string ObtainParam { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("rewardType")]
    public string RewardType { get; set; } = default!;

    [JsonPropertyName("obtainMethod")]
    public string ObtainMethod { get; set; } = default!;

    [JsonPropertyName("previewId")]
    public int? PreviewId { get; set; }
}

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
    public IList<double> SpecialProbList { get; set; } = default!;

    [JsonPropertyName("specialReward")]
    public SpecialReward SpecialReward { get; set; } = default!;
}
