namespace Snap.Data.Mapper.Model.ExcelBinOutput.Product;

public class ProductCardDetailConfigData : DataObject
{
    [JsonPropertyName("cardProductType")]
    public string CardProductType { get; set; } = default!;

    [JsonPropertyName("itemNameTextMapHash")]
    public Text ItemNameTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("totalLimitDays")]
    public int TotalLimitDays { get; set; }

    [JsonPropertyName("days")]
    public int Days { get; set; }

    [JsonPropertyName("hcoinPerDay")]
    public int HcoinPerDay { get; set; }

    [JsonPropertyName("mcoinBase")]
    public int McoinBase { get; set; }

    [JsonPropertyName("baseItemMap")]
    public BaseItemMap BaseItemMap { get; set; } = default!;

    [JsonPropertyName("perDayItemMap")]
    public PerDayItemMap PerDayItemMap { get; set; } = default!;

    [JsonPropertyName("replaceMcoinNum")]
    public int ReplaceMcoinNum { get; set; }

    [JsonPropertyName("firstRewardTextTextMapHash")]
    public Text FirstRewardTextTextMapHash { get; set; }

    [JsonPropertyName("dailyRewardTextTextMapHash")]
    public Text DailyRewardTextTextMapHash { get; set; }

    [JsonPropertyName("totalRewardTextTextMapHash")]
    public Text TotalRewardTextTextMapHash { get; set; }

    [JsonPropertyName("totalDaysTextTextMapHash")]
    public Text TotalDaysTextTextMapHash { get; set; }

    [JsonPropertyName("remainDaysTextTextMapHash")]
    public Text RemainDaysTextTextMapHash { get; set; }

    [JsonPropertyName("remainDaysText2TextMapHash")]
    public Text RemainDaysText2TextMapHash { get; set; }

    [JsonPropertyName("explainTitleTextMapHash")]
    public Text ExplainTitleTextMapHash { get; set; }

    [JsonPropertyName("explainDescTextMapHash")]
    public Text ExplainDescTextMapHash { get; set; }

    [JsonPropertyName("sortLevel")]
    public int SortLevel { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("priceTier")]
    public string PriceTier { get; set; } = default!;

    [JsonPropertyName("shopType")]
    public string ShopType { get; set; } = default!;
}
