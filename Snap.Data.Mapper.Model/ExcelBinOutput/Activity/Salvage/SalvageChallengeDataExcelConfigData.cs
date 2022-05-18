namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salvage;
public class SalvageChallengeDataExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("playType")]
    public string PlayType { get; set; } = default!;

    [JsonPropertyName("BADIMLGKNCF")]
    public int BADIMLGKNCF { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("BLEPPDCNPBE")]
    public IList<int> BLEPPDCNPBE { get; set; } = default!;

    [JsonPropertyName("PJLKGHOPIMH")]
    public IList<int> PJLKGHOPIMH { get; set; } = default!;

    [JsonPropertyName("ALMKLLJFDNG")]
    public int ALMKLLJFDNG { get; set; }

    [JsonPropertyName("OAJGHMFHAJC")]
    public IList<int> OAJGHMFHAJC { get; set; } = default!;
}