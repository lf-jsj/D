namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class PLDAMHDHOLO : DataObject
{
    [JsonPropertyName("targetParamList")]
    public IList<object> TargetParamList { get; set; } = default!;

    [JsonPropertyName("effectStrParam")]
    public string EffectStrParam { get; set; } = string.Empty;

    [JsonPropertyName("effectType")]
    public string? EffectType { get; set; }

    [JsonPropertyName("effectParam1")]
    public int? EffectParam1 { get; set; }

    [JsonPropertyName("effectParam2")]
    public int? EffectParam2 { get; set; }

    [JsonPropertyName("FPABBMBGIFH")]
    public int? FPABBMBGIFH { get; set; }

    [JsonPropertyName("DDLBNPOIENG")]
    public int? DDLBNPOIENG { get; set; }
}
