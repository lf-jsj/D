namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandTask;

public class RandTaskLevelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("minZoneLevel")]
    public int MinZoneLevel { get; set; }

    [JsonPropertyName("maxZoneLevel")]
    public int MaxZoneLevel { get; set; }

    [JsonPropertyName("reviseLevel")]
    public int? ReviseLevel { get; set; }
}