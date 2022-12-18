namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Sumo;

public class ActivitySumoDifficultyExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("KMEAOCFFPBK")]
    public int KMEAOCFFPBK { get; set; }

    [JsonPropertyName("EAANBLBBFEE")]
    public int EAANBLBBFEE { get; set; }

    [JsonPropertyName("LPICMNCMNCG")]
    public float LPICMNCMNCG { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("difficulty")]
    public string? Difficulty { get; set; }
}
