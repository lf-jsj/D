namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class HitLevelTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("hitLevel")]
    public string HitLevel { get; set; } = default!;

    [JsonPropertyName("hitImpulseX")]
    public double? HitImpulseX { get; set; }

    [JsonPropertyName("hitImpulseY")]
    public double? HitImpulseY { get; set; }
}
