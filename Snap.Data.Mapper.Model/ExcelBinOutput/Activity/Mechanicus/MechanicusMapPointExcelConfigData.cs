namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusMapPointExcelConfigData : DataObject
{

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("coordX")]
    public double CoordX { get; set; }

    [JsonPropertyName("coordY")]
    public double CoordY { get; set; }
}