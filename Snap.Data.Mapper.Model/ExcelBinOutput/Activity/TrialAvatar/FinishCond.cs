namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TrialAvatar;

public class FinishCond : DataObject
{
    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;

    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;
}
