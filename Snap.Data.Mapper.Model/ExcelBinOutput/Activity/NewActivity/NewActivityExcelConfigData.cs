namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityExcelConfigData : DataObject
{
    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("activityType")]
    public string ActivityType { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("activitySceneTag")]
    public string ActivitySceneTag { get; set; } = default!;

    [JsonPropertyName("condGroupId")]
    public IList<int> CondGroupId { get; set; } = default!;

    [JsonPropertyName("watcherId")]
    public IList<int> WatcherId { get; set; } = default!;

    [JsonPropertyName("isLoadTerrain")]
    public bool? IsLoadTerrain { get; set; }
}