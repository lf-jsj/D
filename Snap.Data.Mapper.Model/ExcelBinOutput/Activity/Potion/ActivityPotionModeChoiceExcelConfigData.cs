namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Potion;

public class ActivityPotionModeChoiceExcelConfigData : DataObject
{
    [JsonPropertyName("ELIDAIKOINP")]
    public int ELIDAIKOINP { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("scoreRatio")]
    public float ScoreRatio { get; set; }

    [JsonPropertyName("EAANBLBBFEE")]
    public int EAANBLBBFEE { get; set; }
}