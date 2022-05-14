namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;

public class AsterLittleExcelConfigData : DataObject
{
    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("nextStageIdVec")]
    public IList<int> NextStageIdVec { get; set; } = default!;

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("missionVec")]
    public IList<int> MissionVec { get; set; } = default!;

    [JsonPropertyName("watcherIdVec")]
    public IList<int> WatcherIdVec { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}