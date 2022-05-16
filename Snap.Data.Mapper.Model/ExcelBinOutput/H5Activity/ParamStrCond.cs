namespace Snap.Data.Mapper.Model.ExcelBinOutput.H5Activity;

public class ParamStrCond : DataObject
{
    [JsonPropertyName("paramStr")]
    public string ParamStr { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}
