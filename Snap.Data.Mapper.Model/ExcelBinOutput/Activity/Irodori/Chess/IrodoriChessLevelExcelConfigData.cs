namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Chess;

public class IrodoriChessLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;

    [JsonPropertyName("AFKICEPGIIB")]
    public int AFKICEPGIIB { get; set; }

    [JsonPropertyName("ILEMEDEBGAL")]
    public int ILEMEDEBGAL { get; set; }

    [JsonPropertyName("PEBLDIKPLLP")]
    public int PEBLDIKPLLP { get; set; }
}