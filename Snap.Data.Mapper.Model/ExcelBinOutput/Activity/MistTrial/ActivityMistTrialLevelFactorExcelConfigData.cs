namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MistTrial;

public class ActivityMistTrialLevelFactorExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("PMEMGINLFDD")]
    public Text PMEMGINLFDD { get; set; }

    [JsonPropertyName("BIJKHMLDJID")]
    public Text BIJKHMLDJID { get; set; }

    [JsonPropertyName("ADJFJKKGBBE")]
    public Text ADJFJKKGBBE { get; set; }
}
