using Snap.Data.Mapper.Model.Common.Wrapper;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FlightActivity;

public class FlightActivityMedalExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("medalIcon")]
    public string MedalIcon { get; set; } = default!;

    [JsonPropertyName("dailyInfo")]
    public IList<WatcherWrapper> DailyInfo { get; set; } = default!;
}