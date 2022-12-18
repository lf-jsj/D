namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reminder;
public class ReminderExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public Text Id { get; set; }

    [JsonPropertyName("speakerTextMapHash")]
    public Text SpeakerTextMapHash { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("showTime")]
    public float ShowTime { get; set; }

    [JsonPropertyName("nextReminderId")]
    public long NextReminderId { get; set; }

    [JsonPropertyName("soundEffect")]
    public string SoundEffect { get; set; } = default!;

    [JsonPropertyName("hasAudio")]
    public bool HasAudio { get; set; }

    [JsonPropertyName("delay")]
    public float? Delay { get; set; }

    [JsonPropertyName("style")]
    public string Style { get; set; } = default!;
}
