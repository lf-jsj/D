namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class MainQuestExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("activeMode")]
    public string ActiveMode { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("luaPath")]
    public string LuaPath { get; set; } = default!;

    [JsonPropertyName("suggestTrackMainQuestList")]
    public IList<int> SuggestTrackMainQuestList { get; set; } = default!;

    [JsonPropertyName("rewardIdList")]
    public IList<int> RewardIdList { get; set; } = default!;

    [JsonPropertyName("showType")]
    public string ShowType { get; set; } = default!;

    [JsonPropertyName("HEPKFJAACPK")]
    public IList<int> HEPKFJAACPK { get; set; } = default!;

    [JsonPropertyName("FHKEDHGONKD")]
    public IList<int> FHKEDHGONKD { get; set; } = default!;

    [JsonPropertyName("repeatable")]
    public bool? Repeatable { get; set; }

    [JsonPropertyName("KICFAGEJAGC")]
    public int? KICFAGEJAGC { get; set; }

    [JsonPropertyName("series")]
    public int? Series { get; set; }

    [JsonPropertyName("chapterId")]
    public int? ChapterId { get; set; }

    [JsonPropertyName("showRedPoint")]
    public bool? ShowRedPoint { get; set; }

    [JsonPropertyName("taskID")]
    public int? TaskID { get; set; }

    [JsonPropertyName("mainQuestTag")]
    public string MainQuestTag { get; set; } = default!;

    [JsonPropertyName("ODNELEODCEB")]
    public int? ODNELEODCEB { get; set; }

    [JsonPropertyName("suggestTrackOutOfOrder")]
    public bool? SuggestTrackOutOfOrder { get; set; }

    [JsonPropertyName("activityId")]
    public int? ActivityId { get; set; }

    [JsonPropertyName("recommendLevel")]
    public int? RecommendLevel { get; set; }
}
