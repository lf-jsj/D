namespace Snap.Data.Mapper.Model.ExcelBinOutput.Vehicle;

public class VehicleSkillDepotExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("APMNHIMGMBP")]
    public IList<int> APMNHIMGMBP { get; set; } = default!;
}