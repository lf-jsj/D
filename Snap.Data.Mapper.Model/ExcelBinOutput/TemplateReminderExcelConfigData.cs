namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class TemplateReminderExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("param")]
    public string Param { get; set; } = default!;

    [JsonPropertyName("showTime")]
    public float? ShowTime { get; set; }

    [JsonPropertyName("style")]
    public string Style { get; set; } = default!;

    [JsonPropertyName("activityType")]
    public string ActivityType { get; set; } = default!;
}