namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Firework;
public class LanV2FireworksChallengeDataExcelConfigData : DataObject
{
    [JsonPropertyName("challengeId")]
    public int ChallengeId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("HFDLEHHMNHP")]
    public IList<int> HFDLEHHMNHP { get; set; } = default!;

    [JsonPropertyName("NIOMBDJCAGJ")]
    public int NIOMBDJCAGJ { get; set; }

    [JsonPropertyName("AEBGGCCEHBA")]
    public int AEBGGCCEHBA { get; set; }

    [JsonPropertyName("HDIGBEJABCP")]
    public int HDIGBEJABCP { get; set; }

    [JsonPropertyName("BJFEIGAOFLN")]
    public int BJFEIGAOFLN { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("IKIILGHJEPP")]
    public int IKIILGHJEPP { get; set; }
}
