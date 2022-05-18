namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterTitleExcelConfigData : DataObject
{
    [JsonPropertyName("titleID")]
    public int TitleID { get; set; }

    [JsonPropertyName("titleNameTextMapHash")]
    public Text TitleNameTextMapHash { get; set; }

    [JsonPropertyName("isInverted")]
    public bool IsInverted { get; set; }
}