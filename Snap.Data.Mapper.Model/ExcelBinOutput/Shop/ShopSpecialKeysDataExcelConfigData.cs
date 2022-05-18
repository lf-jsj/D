namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopSpecialKeysDataExcelConfigData : DataObject
{
    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    [JsonPropertyName("JABKGNFABCO")]
    public int JABKGNFABCO { get; set; }
}