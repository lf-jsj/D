namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;
public class TowerBuffExcelConfigData : DataObject
{
    [JsonPropertyName("towerBuffId")]
    public int TowerBuffId { get; set; }

    [JsonPropertyName("lastingType")]
    public string LastingType { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("buffIcon")]
    public string BuffIcon { get; set; } = default!;

    [JsonPropertyName("buffId")]
    public int BuffId { get; set; }
}