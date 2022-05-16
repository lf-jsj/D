namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Bartender;

public class BartenderEventExcelConfigData : DataObject
{
    [JsonPropertyName("effectName")]
    public string EffectName { get; set; } = default!;

    [JsonPropertyName("effectType")]
    public string EffectType { get; set; } = default!;

    [JsonPropertyName("NPOPNFJHMND")]
    public int? NPOPNFJHMND { get; set; }
}