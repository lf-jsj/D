namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LoadingTipsExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("tipsTitleTextMapHash")]
    public Text TipsTitleTextMapHash { get; set; }

    [JsonPropertyName("tipsDescTextMapHash")]
    public Text TipsDescTextMapHash { get; set; }

    [JsonPropertyName("stageID")]
    public string StageID { get; set; } = default!;

    [JsonPropertyName("startTime")]
    public string StartTime { get; set; } = default!;

    [JsonPropertyName("endTime")]
    public string EndTime { get; set; } = default!;

    [JsonPropertyName("limitOpenState")]
    public string LimitOpenState { get; set; } = default!;

    [JsonPropertyName("preMainQuestIds")]
    public string PreMainQuestIds { get; set; } = default!;

    [JsonPropertyName("KLHLGGDOMPN")]
    public IList<DataObject> KLHLGGDOMPN { get; set; } = default!;

    [JsonPropertyName("NHCMLDFLLNN")]
    public IList<int> NHCMLDFLLNN { get; set; } = default!;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("minLevel")]
    public int? MinLevel { get; set; }
}
