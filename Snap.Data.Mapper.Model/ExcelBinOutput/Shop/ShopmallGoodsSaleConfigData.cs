namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopmallGoodsSaleConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    [JsonPropertyName("INEDCGIIIEI")]
    public int INEDCGIIIEI { get; set; }

    [JsonPropertyName("discountRate")]
    public double DiscountRate { get; set; }

    [JsonPropertyName("ILCCMAJJGDG")]
    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime ILCCMAJJGDG { get; set; }

    [JsonPropertyName("CCFBPKNAEOO")]
    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime CCFBPKNAEOO { get; set; }
}