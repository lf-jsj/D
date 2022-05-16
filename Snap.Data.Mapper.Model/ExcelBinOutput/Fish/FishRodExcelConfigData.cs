namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;

public class FishRodExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("PAAIDJHHALD")]
    public double PAAIDJHHALD { get; set; }

    [JsonPropertyName("cityId")]
    public int? CityId { get; set; }

    [JsonPropertyName("MCDLDLFLODL")]
    public double? MCDLDLFLODL { get; set; }

    [JsonPropertyName("EOKEPMLDGOA")]
    public double? EOKEPMLDGOA { get; set; }

    [JsonPropertyName("DBONCGLALEL")]
    public double? DBONCGLALEL { get; set; }
}
