namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;

public class FishRodExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("PAAIDJHHALD")]
    public float PAAIDJHHALD { get; set; }

    [JsonPropertyName("cityId")]
    public int? CityId { get; set; }

    [JsonPropertyName("MCDLDLFLODL")]
    public float? MCDLDLFLODL { get; set; }

    [JsonPropertyName("EOKEPMLDGOA")]
    public float? EOKEPMLDGOA { get; set; }

    [JsonPropertyName("DBONCGLALEL")]
    public float? DBONCGLALEL { get; set; }
}
