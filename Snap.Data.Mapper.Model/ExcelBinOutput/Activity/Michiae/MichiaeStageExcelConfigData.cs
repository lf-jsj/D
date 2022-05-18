namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeStageExcelConfigData : DataObject
{
    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;

    [JsonPropertyName("CCGJKFHANLA")]
    public int CCGJKFHANLA { get; set; }

    [JsonPropertyName("HALGHCPLKHD")]
    public int HALGHCPLKHD { get; set; }

    [JsonPropertyName("tabNameTextMapHash")]
    public Text TabNameTextMapHash { get; set; }
}