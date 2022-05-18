namespace Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;

public class PS5GroupExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;

    [JsonPropertyName("KJJCPPOLEJN")]
    public string KJJCPPOLEJN { get; set; } = default!;
}