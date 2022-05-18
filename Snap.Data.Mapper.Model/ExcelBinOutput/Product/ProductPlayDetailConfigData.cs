namespace Snap.Data.Mapper.Model.ExcelBinOutput.Product;

public class ProductPlayDetailConfigData : DataObject
{
    [JsonPropertyName("playType")]
    public string PlayType { get; set; } = default!;

    [JsonPropertyName("itemNameTextMapHash")]
    public Text ItemNameTextMapHash { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("priceTier")]
    public string PriceTier { get; set; } = default!;
}