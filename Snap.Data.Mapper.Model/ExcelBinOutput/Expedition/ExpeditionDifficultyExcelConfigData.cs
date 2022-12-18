namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class ExpeditionDifficultyExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("needHours")]
    public int NeedHours { get; set; }

    [JsonPropertyName("minPlayer")]
    public int MinPlayer { get; set; }

    [JsonPropertyName("maxPlayer")]
    public int MaxPlayer { get; set; }

    [JsonPropertyName("minRefreshCount")]
    public int MinRefreshCount { get; set; }

    [JsonPropertyName("maxRefreshCount")]
    public int MaxRefreshCount { get; set; }

    [JsonPropertyName("coef")]
    public float Coef { get; set; }
}