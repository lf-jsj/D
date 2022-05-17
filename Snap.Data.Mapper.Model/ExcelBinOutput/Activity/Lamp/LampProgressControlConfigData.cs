namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Lamp;

public class LampProgressControlConfigData : DataObject
{
    [JsonPropertyName("hour")]
    public int Hour { get; set; }

    [JsonPropertyName("minProgress")]
    public int MinProgress { get; set; }

    [JsonPropertyName("maxProgress")]
    public int MaxProgress { get; set; }
}