namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopmallSubTabExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("subTagNameTextMapHash")]
    public Text SubTagNameTextMapHash { get; set; }
}