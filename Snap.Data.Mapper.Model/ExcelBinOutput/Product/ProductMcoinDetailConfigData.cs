namespace Snap.Data.Mapper.Model.ExcelBinOutput.Product;

public class ProductMcoinDetailConfigData : DataObject
{
    [JsonPropertyName("itemNameTextMapHash")]
    public Text ItemNameTextMapHash { get; set; }

    [JsonPropertyName("primNameTextMapHash")]
    public Text PrimNameTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("mcoinNum")]
    public int McoinNum { get; set; }

    [JsonPropertyName("mcoinFirst")]
    public int McoinFirst { get; set; }

    [JsonPropertyName("seqence")]
    public int Seqence { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("priceTier")]
    public string PriceTier { get; set; } = default!;

    [JsonPropertyName("shopType")]
    public string ShopType { get; set; } = default!;

    [JsonPropertyName("mcoinNonFirst")]
    public int? McoinNonFirst { get; set; }
}