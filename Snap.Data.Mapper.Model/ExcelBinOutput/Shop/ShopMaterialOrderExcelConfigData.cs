namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopMaterialOrderExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("shopType")]
    public string ShopType { get; set; } = default!;
}