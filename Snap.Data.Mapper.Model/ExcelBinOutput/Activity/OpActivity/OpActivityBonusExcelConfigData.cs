namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.OpActivity;
public class OpActivityBonusExcelConfigData : DataObject
{
    [JsonPropertyName("bonusId")]
    public int BonusId { get; set; }

    [JsonPropertyName("sourceType")]
    public string SourceType { get; set; } = default!;

    [JsonPropertyName("sourceParam")]
    public string SourceParam { get; set; } = default!;

    [JsonPropertyName("openLevel")]
    public int OpenLevel { get; set; }

    [JsonPropertyName("bonusRatio")]
    public int BonusRatio { get; set; }

    [JsonPropertyName("textMapIdList")]
    public IList<string> TextMapIdList { get; set; } = default!;

    [JsonPropertyName("trackPara")]
    public IList<DataObject> TrackPara { get; set; } = default!;

    [JsonPropertyName("ONHEPJNAKCH")]
    public int ONHEPJNAKCH { get; set; }

    [JsonPropertyName("CAMMDFGNAHA")]
    public int CAMMDFGNAHA { get; set; }
}
