namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FleurFair;

public class FleurFairDungeonStatExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("statType")]
    public string StatType { get; set; } = default!;

    [JsonPropertyName("statParamList")]
    public IList<string> StatParamList { get; set; } = default!;

    [JsonPropertyName("orderingType")]
    public string OrderingType { get; set; } = default!;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("statMethod")]
    public string StatMethod { get; set; } = default!;
}
