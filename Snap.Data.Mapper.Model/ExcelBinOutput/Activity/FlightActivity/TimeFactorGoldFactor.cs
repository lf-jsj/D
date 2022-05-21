namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FlightActivity;

public class TimeFactorGoldFactor : DataObject
{
    [JsonPropertyName("timeFactor")]
    public int TimeFactor { get; set; }

    [JsonPropertyName("goldFactor")]
    public int GoldFactor { get; set; }
}
