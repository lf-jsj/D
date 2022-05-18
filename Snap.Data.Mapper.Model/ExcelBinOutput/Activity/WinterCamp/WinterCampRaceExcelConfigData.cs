namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.WinterCamp;

public class WinterCampRaceExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("LBMLOHAAKOG")]
    public int LBMLOHAAKOG { get; set; }

    [JsonPropertyName("IIHBCMCCLDG")]
    public IList<int> IIHBCMCCLDG { get; set; } = default!;

    [JsonPropertyName("DHLLKLCPMBF")]
    public IList<int> DHLLKLCPMBF { get; set; } = default!;

    [JsonPropertyName("AJBAGEDDMHK")]
    public int AJBAGEDDMHK { get; set; }

    [JsonPropertyName("OOAEFGFAJMM")]
    public int OOAEFGFAJMM { get; set; }

    [JsonPropertyName("GCFHCLIIBPG")]
    public int GCFHCLIIBPG { get; set; }

    [JsonPropertyName("OBAEEEINKGK")]
    public IList<int> OBAEEEINKGK { get; set; } = default!;
}