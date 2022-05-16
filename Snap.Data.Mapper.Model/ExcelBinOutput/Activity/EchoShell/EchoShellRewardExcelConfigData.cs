namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.EchoShell;

public class EchoShellRewardExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("GBOBEAGJGDN")]
    public int GBOBEAGJGDN { get; set; }

    [JsonPropertyName("IEEMKAOKLCA")]
    public bool? IEEMKAOKLCA { get; set; }
}
