namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class DisplayItemExcelConfigData : DataObject
{
    [JsonPropertyName("typeDescTextMapHash")]
    public Text TypeDescTextMapHash { get; set; }

    [JsonPropertyName("rankLevel")]
    public int RankLevel { get; set; }

    [JsonPropertyName("displayType")]
    public string DisplayType { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("itemType")]
    public string ItemType { get; set; } = default!;

    [JsonPropertyName("param")]
    public int? Param { get; set; }
}
