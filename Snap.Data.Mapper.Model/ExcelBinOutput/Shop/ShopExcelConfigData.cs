namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;
public class ShopExcelConfigData : DataObject
{
    [JsonPropertyName("shopId")]
    public int ShopId { get; set; }

    [JsonPropertyName("shopType")]
    public string ShopType { get; set; } = default!;

    [JsonPropertyName("openStateType")]
    public string OpenStateType { get; set; } = default!;

    [JsonPropertyName("refreshType")]
    public string RefreshType { get; set; } = default!;

    [JsonPropertyName("refreshParam")]
    public int? RefreshParam { get; set; }

    [JsonPropertyName("cityId")]
    public int? CityId { get; set; }

    [JsonPropertyName("cityDiscountLevel")]
    public int? CityDiscountLevel { get; set; }

    [JsonPropertyName("scoinDiscountRate")]
    public int? ScoinDiscountRate { get; set; }

    [JsonPropertyName("vipFuncID")]
    public int? VipFuncID { get; set; }
}
