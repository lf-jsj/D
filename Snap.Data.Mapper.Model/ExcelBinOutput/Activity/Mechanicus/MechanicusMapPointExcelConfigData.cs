namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusMapPointExcelConfigData : DataObject
{

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("coordX")]
    public float CoordX { get; set; }

    [JsonPropertyName("coordY")]
    public float CoordY { get; set; }
}