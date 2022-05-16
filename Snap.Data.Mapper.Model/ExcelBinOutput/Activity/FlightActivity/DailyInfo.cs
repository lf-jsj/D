namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FlightActivity;

public class DailyInfo : DataObject
{
    [JsonPropertyName("watcher")]
    public int Watcher { get; set; }
}
