namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopmallRecommendConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("subTabId")]
    public int SubTabId { get; set; }

    [JsonPropertyName("shopType")]
    public string ShopType { get; set; } = default!;

    [JsonPropertyName("condVec")]
    public IList<DataObject> CondVec { get; set; } = default!;

    [JsonPropertyName("configIdVec")]
    public IList<int> ConfigIdVec { get; set; } = default!;

    [JsonPropertyName("goodsIdVec")]
    public IList<GoodsIdVec> GoodsIdVec { get; set; } = default!;

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("oneCardIconName")]
    public string OneCardIconName { get; set; } = default!;

    [JsonPropertyName("colShowIconName")]
    public IList<DataObject> ColShowIconName { get; set; } = default!;
}