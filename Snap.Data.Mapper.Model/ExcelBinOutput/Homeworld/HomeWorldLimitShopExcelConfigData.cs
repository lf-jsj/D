using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldLimitShopExcelConfigData : DataObject
{
    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    [JsonPropertyName("itemID")]
    public int ItemID { get; set; }

    [JsonPropertyName("poolID")]
    public int PoolID { get; set; }

    [JsonPropertyName("cond")]
    public IList<Cond> Cond { get; set; } = default!;

    [JsonPropertyName("buyLimit")]
    public int BuyLimit { get; set; }

    [JsonPropertyName("costItems")]
    public IList<IdCount<int>> CostItems { get; set; } = default!;

    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}