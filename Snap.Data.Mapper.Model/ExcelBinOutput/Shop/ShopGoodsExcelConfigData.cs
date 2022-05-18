namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopGoodsExcelConfigData : DataObject
{
    [JsonPropertyName("goodsId")]
    public int GoodsId { get; set; }

    [JsonPropertyName("subTagNameTextMapHash")]
    public Text SubTagNameTextMapHash { get; set; }

    [JsonPropertyName("shopType")]
    public int ShopType { get; set; }

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("itemCount")]
    public int ItemCount { get; set; }

    [JsonPropertyName("costItems")]
    public IList<CountableItem> CostItems { get; set; } = default!;

    [JsonPropertyName("beginTime")]
    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime BeginTime { get; set; }

    [JsonPropertyName("endTime")]
    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime EndTime { get; set; }

    [JsonPropertyName("preconditionParamList")]
    public IList<string> PreconditionParamList { get; set; } = default!;

    [JsonPropertyName("minShowLevel")]
    public int MinShowLevel { get; set; }

    [JsonPropertyName("minPlayerLevel")]
    public int MinPlayerLevel { get; set; }

    [JsonPropertyName("maxPlayerLevel")]
    public int MaxPlayerLevel { get; set; }

    [JsonPropertyName("sortLevel")]
    public int SortLevel { get; set; }

    [JsonPropertyName("platformTypeList")]
    public IList<DataObject> PlatformTypeList { get; set; } = default!;

    [JsonPropertyName("buyLimit")]
    public int? BuyLimit { get; set; }

    [JsonPropertyName("isBuyOnce")]
    public bool? IsBuyOnce { get; set; }

    [JsonPropertyName("precondition")]
    public string Precondition { get; set; } = default!;

    [JsonPropertyName("costScoin")]
    public int? CostScoin { get; set; }

    [JsonPropertyName("refreshType")]
    public string RefreshType { get; set; } = default!;

    [JsonPropertyName("refreshParam")]
    public int? RefreshParam { get; set; }

    [JsonPropertyName("ENPLKLEHNDF")]
    public bool? ENPLKLEHNDF { get; set; }

    [JsonPropertyName("subTabId")]
    public int? SubTabId { get; set; }

    [JsonPropertyName("costHcoin")]
    public int? CostHcoin { get; set; }

    [JsonPropertyName("rotateId")]
    public int? RotateId { get; set; }

    [JsonPropertyName("discountRate")]
    public double? DiscountRate { get; set; }

    [JsonPropertyName("originalPrice")]
    public int? OriginalPrice { get; set; }

    [JsonPropertyName("preconditionParam")]
    public int? PreconditionParam { get; set; }

    [JsonPropertyName("showId")]
    public int? ShowId { get; set; }

    [JsonPropertyName("costMcoin")]
    public int? CostMcoin { get; set; }

    [JsonPropertyName("secondarySheetId")]
    public int? SecondarySheetId { get; set; }

    [JsonPropertyName("chooseOneGroupId")]
    public int? ChooseOneGroupId { get; set; }
}