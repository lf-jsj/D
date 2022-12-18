namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FlightActivity;
public class FlightActivityDayExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("pos")]
    public IList<float> Pos { get; set; } = default!;
}
