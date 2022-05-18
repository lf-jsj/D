namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;

public class ReputationEntranceExcelConfigData : DataObject
{
    [JsonPropertyName("textId")]
    public int TextId { get; set; }

    [JsonPropertyName("entranceId")]
    public string EntranceId { get; set; } = default!;

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("goodsIdVec")]
    public IList<GoodsIdVec> GoodsIdVec { get; set; } = default!;

    [JsonPropertyName("condNameVec")]
    public IList<Text> CondNameVec { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("explainTitleTextMapHash")]
    public Text ExplainTitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("order")]
    public int Order { get; set; }
}