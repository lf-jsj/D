namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class BlossomOpenExcelConfigData : DataObject
{
    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("openLevel")]
    public int OpenLevel { get; set; }
}