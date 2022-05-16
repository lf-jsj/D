namespace Snap.Data.Mapper.Model.ExcelBinOutput.Guide;

public class GuideTriggerExcelConfigData : DataObject
{
    [JsonPropertyName("guideName")]
    public string GuideName { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("openState")]
    public string OpenState { get; set; } = default!;

    [JsonPropertyName("param1")]
    public int? Param1 { get; set; }
}