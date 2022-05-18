namespace Snap.Data.Mapper.Model.ExcelBinOutput.Match;

public class MatchPunishExcelConfigData : DataObject
{
    [JsonPropertyName("times")]
    public int Times { get; set; }

    [JsonPropertyName("punishTime")]
    public int PunishTime { get; set; }
}