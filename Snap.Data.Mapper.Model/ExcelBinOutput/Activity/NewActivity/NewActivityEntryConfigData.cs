namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityEntryConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityType")]
    public string ActivityType { get; set; } = default!;

    [JsonPropertyName("sortPriority")]
    public int SortPriority { get; set; }

    [JsonPropertyName("tabIcon")]
    public string TabIcon { get; set; } = default!;

    [JsonPropertyName("LHJCOMKFLAJ")]
    public string LHJCOMKFLAJ { get; set; } = default!;

    [JsonPropertyName("ACGDDJJECAM")]
    public string ACGDDJJECAM { get; set; } = default!;

    [JsonPropertyName("tabNameTextMapHash")]
    public Text TabNameTextMapHash { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
}