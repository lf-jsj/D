namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class BlossomSectionOrderExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("sectionId")]
    public int SectionId { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }
}
