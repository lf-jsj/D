namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SummerTime;

public class ActivitySummerTimeRaceExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("HGOBIMGIBNF")]
    public IList<int> HGOBIMGIBNF { get; set; } = default!;

    [JsonPropertyName("FCDBNBNJECE")]
    public IList<double> FCDBNBNJECE { get; set; } = default!;

    [JsonPropertyName("JNGIPFOIHCM")]
    public IList<int> JNGIPFOIHCM { get; set; } = default!;

    [JsonPropertyName("levelTitleTextMapHash")]
    public Text LevelTitleTextMapHash { get; set; }

    [JsonPropertyName("AJBAGEDDMHK")]
    public int AJBAGEDDMHK { get; set; }

    [JsonPropertyName("OOAEFGFAJMM")]
    public int OOAEFGFAJMM { get; set; }

    [JsonPropertyName("DCJKKDIHHIO")]
    public int DCJKKDIHHIO { get; set; }

    [JsonPropertyName("OLIADKEJKKE")]
    public int OLIADKEJKKE { get; set; }

    [JsonPropertyName("NIOEKHFELEC")]
    public int NIOEKHFELEC { get; set; }
}
