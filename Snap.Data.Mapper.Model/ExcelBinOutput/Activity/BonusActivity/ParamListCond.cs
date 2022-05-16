namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BonusActivity;

public class ParamListCond : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<int> ParamList { get; set; } = default!;
}
