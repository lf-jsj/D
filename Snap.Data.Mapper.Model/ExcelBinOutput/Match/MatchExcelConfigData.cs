namespace Snap.Data.Mapper.Model.ExcelBinOutput.Match;
public class MatchExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("matchSubType")]
    public string MatchSubType { get; set; } = default!;

    [JsonPropertyName("minPlayerNum")]
    public int MinPlayerNum { get; set; }

    [JsonPropertyName("maxPlayerNum")]
    public int MaxPlayerNum { get; set; }

    [JsonPropertyName("confirmTime")]
    public int ConfirmTime { get; set; }
}

