namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Spice;
public class ActivitySpiceExcelConfigData : DataObject
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("EKJCMKPDJPN")]
    public int EKJCMKPDJPN { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("CIFPJJLOFCE")]
    public int CIFPJJLOFCE { get; set; }

    [JsonPropertyName("FKDCKFLFLBJ")]
    public int FKDCKFLFLBJ { get; set; }

    [JsonPropertyName("JBPGHGIDBPH")]
    public int JBPGHGIDBPH { get; set; }
}
