namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.OpActivity;

public class OpActivityExcelConfigData : DataObject
{
    [JsonPropertyName("opActivityId")]
    public int OpActivityId { get; set; }

    [JsonPropertyName("bonusType")]
    public string BonusType { get; set; } = default!;

    [JsonPropertyName("bonusValue")]
    public int BonusValue { get; set; }

    [JsonPropertyName("bonusList")]
    public IList<int> BonusList { get; set; } = default!;

    [JsonPropertyName("icon")]
    public int Icon { get; set; }

    [JsonPropertyName("tabText")]
    public string TabText { get; set; } = default!;

    [JsonPropertyName("textMapIdList")]
    public IList<string> TextMapIdList { get; set; } = default!;
}