namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterDescribeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("titleID")]
    public int TitleID { get; set; }

    [JsonPropertyName("specialNameLabID")]
    public int SpecialNameLabID { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;
}