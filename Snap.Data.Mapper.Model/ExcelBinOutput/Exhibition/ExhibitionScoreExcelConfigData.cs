namespace Snap.Data.Mapper.Model.ExcelBinOutput.Exhibition;

public class ExhibitionScoreExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("ICLIPNDHNDO")]
    public int ICLIPNDHNDO { get; set; }

    [JsonPropertyName("scoreType")]
    public string ScoreType { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("LCCBLIJCNKL")]
    public bool? LCCBLIJCNKL { get; set; }
}