namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LoadingSituationExcelConfigData : DataObject
{
    [JsonPropertyName("stageID")]
    public int StageID { get; set; }

    [JsonPropertyName("HEJHANPCJAH")]
    public string HEJHANPCJAH { get; set; } = default!;

    [JsonPropertyName("HODPOHLOKEH")]
    public IList<int> HODPOHLOKEH { get; set; } = default!;

    [JsonPropertyName("HHANKNLELDG")]
    public IList<int> HHANKNLELDG { get; set; } = default!;

    [JsonPropertyName("DFPMKJEDIJM")]
    public string DFPMKJEDIJM { get; set; } = default!;

    [JsonPropertyName("picPath")]
    public string PicPath { get; set; } = default!;
}
