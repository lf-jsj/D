namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FindHilichurl;

public class FindHilichurlHiliWeiExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dayIndex")]
    public int DayIndex { get; set; }

    [JsonPropertyName("durationHint")]
    public string DurationHint { get; set; } = default!;

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("positionCenter")]
    public IList<double> PositionCenter { get; set; } = default!;

    [JsonPropertyName("positionRadius")]
    public int PositionRadius { get; set; }

    [JsonPropertyName("watcherID")]
    public int WatcherID { get; set; }
}