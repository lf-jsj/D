namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class TargetTypeEffectParam3 : ChessEffectParam
{
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    [JsonPropertyName("effectParam3")]
    public int? EffectParam3 { get; set; }
}
