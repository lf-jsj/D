namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class TalkExcelConfigData : DataObject
{
    [JsonPropertyName("trialAvatarId")]
    public int TrialAvatarId { get; set; }

    [JsonPropertyName("trialAvatarParamList")]
    public IList<int> TrialAvatarParamList { get; set; } = default!;

    [JsonPropertyName("isDynamicLevel")]
    public bool IsDynamicLevel { get; set; }
}