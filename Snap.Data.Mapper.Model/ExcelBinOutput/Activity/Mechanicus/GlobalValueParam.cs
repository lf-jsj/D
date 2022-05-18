namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class GlobalValueParam : DataObject
{
    [JsonPropertyName("key")]
    public string Key { get; set; } = default!;

    [JsonPropertyName("value")]
    public double Value { get; set; }
}
