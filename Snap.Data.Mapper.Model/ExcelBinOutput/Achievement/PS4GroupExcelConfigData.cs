namespace Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;

public class PS4GroupExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;
}