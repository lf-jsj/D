namespace Snap.Data.Mapper.Model.ExcelBinOutput.Music;
public class MusicInfoConfigData : DataObject
{
    [JsonPropertyName("musicID")]
    public int MusicID { get; set; }

    [JsonPropertyName("musicTime")]
    public int MusicTime { get; set; }

    [JsonPropertyName("levelId")]
    public IList<int> LevelId { get; set; } = default!;

    [JsonPropertyName("musicNameTextMapHash")]
    public Text MusicNameTextMapHash { get; set; }

    [JsonPropertyName("musicDescTextMapHash")]
    public Text MusicDescTextMapHash { get; set; }

    [JsonPropertyName("ABLMMJNNOCK")]
    public Text ABLMMJNNOCK { get; set; }

    [JsonPropertyName("AIDJADDCHFC")]
    public Text AIDJADDCHFC { get; set; }

    [JsonPropertyName("condID")]
    public int CondID { get; set; }

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;

    [JsonPropertyName("avatarID")]
    public int AvatarID { get; set; }

    [JsonPropertyName("pointID")]
    public int PointID { get; set; }

    [JsonPropertyName("GJPJODKEBLG")]
    public int GJPJODKEBLG { get; set; }

    [JsonPropertyName("IDCILEFEPCI")]
    public int IDCILEFEPCI { get; set; }
}
