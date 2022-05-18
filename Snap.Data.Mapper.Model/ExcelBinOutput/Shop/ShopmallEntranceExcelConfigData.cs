namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopmallEntranceExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("subTabList")]
    public IList<int> SubTabList { get; set; } = default!;

    [JsonPropertyName("shopType")]
    public string ShopType { get; set; } = default!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("showType")]
    public string ShowType { get; set; } = default!;

    [JsonPropertyName("order")]
    public int Order { get; set; }
}