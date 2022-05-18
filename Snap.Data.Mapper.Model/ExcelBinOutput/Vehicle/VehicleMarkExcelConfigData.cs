namespace Snap.Data.Mapper.Model.ExcelBinOutput.Vehicle;
public class VehicleMarkExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("markIconTypeName")]
    public string MarkIconTypeName { get; set; } = default!;
}