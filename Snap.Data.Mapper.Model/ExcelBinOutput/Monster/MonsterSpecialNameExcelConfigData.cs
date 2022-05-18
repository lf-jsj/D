namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterSpecialNameExcelConfigData : DataObject
{
    [JsonPropertyName("specialNameID")]
    public int SpecialNameID { get; set; }

    [JsonPropertyName("specialNameLabID")]
    public int SpecialNameLabID { get; set; }

    [JsonPropertyName("specialNameTextMapHash")]
    public Text SpecialNameTextMapHash { get; set; }

    [JsonPropertyName("isInRandomList")]
    public bool? IsInRandomList { get; set; }
}