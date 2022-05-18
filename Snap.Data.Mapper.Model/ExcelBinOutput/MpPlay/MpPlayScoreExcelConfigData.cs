namespace Snap.Data.Mapper.Model.ExcelBinOutput.MpPlay;

public class MpPlayScoreExcelConfigData : DataObject
{
    [JsonPropertyName("playType")]
    public string PlayType { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<int> Param { get; set; } = default!;

    [JsonPropertyName("isCalcScore")]
    public bool IsCalcScore { get; set; }
}