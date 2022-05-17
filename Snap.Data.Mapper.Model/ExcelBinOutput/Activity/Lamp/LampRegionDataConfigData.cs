namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Lamp;

public class LampRegionDataConfigData : DataObject
{
    [JsonPropertyName("region")]
    public string Region { get; set; } = default!;

    [JsonPropertyName("factor")]
    public int Factor { get; set; }
}