namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Effigy;

public class EffigyRewardExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("scoreGrade")]
    public int ScoreGrade { get; set; }

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }
}