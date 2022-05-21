namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Chess;

public class IrodoriChessEffectParam : DataObject
{
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
}
