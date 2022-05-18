namespace Snap.Data.Mapper.Model.ExcelBinOutput.Offering;

public class OfferingVersionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("offeringId")]
    public int OfferingId { get; set; }

    [JsonPropertyName("PMNIGHHADFD")]
    public int PMNIGHHADFD { get; set; }
}