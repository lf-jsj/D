namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeBossChallengeExcelConfigData : DataObject
{
    [JsonPropertyName("levelID")]
    public int LevelID { get; set; }

    [JsonPropertyName("levelTitleTextMapHash")]
    public Text LevelTitleTextMapHash { get; set; }

    [JsonPropertyName("levelDescTextMapHash")]
    public Text LevelDescTextMapHash { get; set; }

    [JsonPropertyName("groupID")]
    public int GroupID { get; set; }
}