namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FleurFair;
public class FleurFairBuffEnergyStatExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("statParam")]
    public string StatParam { get; set; } = default!;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }
}
