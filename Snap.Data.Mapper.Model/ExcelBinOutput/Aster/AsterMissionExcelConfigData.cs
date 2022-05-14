namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;

public class AsterMissionExcelConfigData : DataObject
{
    [JsonPropertyName("missionId")]
    public int MissionId { get; set; }

    [JsonPropertyName("phase")]
    public int Phase { get; set; }

    [JsonPropertyName("watcherId")]
    public int WatcherId { get; set; }

    [JsonPropertyName("transPointId")]
    public int TransPointId { get; set; }

    [JsonPropertyName("tracePoint")]
    public string TracePoint { get; set; } = default!;

    [JsonPropertyName("perfabPathHashSuffix")]
    public HashSuffix PerfabPathHashSuffix { get; set; }

    [JsonPropertyName("perfabPathHashPre")]
    public HashPre PerfabPathHashPre { get; set; }
}