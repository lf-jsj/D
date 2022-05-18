namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusCardEffectExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("targetType")]
    public string TargetType { get; set; } = default!;

    [JsonPropertyName("targetParamList")]
    public IList<int> TargetParamList { get; set; } = default!;

    [JsonPropertyName("effectType")]
    public string EffectType { get; set; } = default!;

    [JsonPropertyName("effectStrParam")]
    public string EffectStrParam { get; set; } = default!;

    [JsonPropertyName("effectParam1")]
    public int EffectParam1 { get; set; }

    [JsonPropertyName("effectParam2")]
    public int? EffectParam2 { get; set; }
}