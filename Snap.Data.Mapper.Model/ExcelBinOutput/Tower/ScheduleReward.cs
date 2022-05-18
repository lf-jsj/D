namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class ScheduleReward : DataObject
{
    [JsonPropertyName("minStarCount")]
    public int MinStarCount { get; set; } = default!;
}
