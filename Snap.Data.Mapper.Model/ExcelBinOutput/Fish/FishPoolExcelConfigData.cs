namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;
public class FishPoolExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("stockList")]
    public IList<int> StockList { get; set; } = default!;

    [JsonPropertyName("stockGuarantee")]
    public IDictionary<string,int> StockGuarantee { get; set; } = default!;

    [JsonPropertyName("stockLimitList")]
    public IList<StockLimit> StockLimitList { get; set; } = default!;

    [JsonPropertyName("maxNum")]
    public int MaxNum { get; set; }

    [JsonPropertyName("poolNameTextMapHash")]
    public Text PoolNameTextMapHash { get; set; }

    [JsonPropertyName("poolDescTextMapHash")]
    public Text PoolDescTextMapHash { get; set; }

    [JsonPropertyName("abilityGroup")]
    public string AbilityGroup { get; set; } = default!;

    [JsonPropertyName("teamAbilityGroup")]
    public string TeamAbilityGroup { get; set; } = default!;

    [JsonPropertyName("dropIdList")]
    public IList<int> DropIdList { get; set; } = default!;

    [JsonPropertyName("excludeFish")]
    public IList<int> ExcludeFish { get; set; } = default!;

    [JsonPropertyName("dailyLimitNum")]
    public int? DailyLimitNum { get; set; }

    [JsonPropertyName("cityId")]
    public int? CityId { get; set; }
}
