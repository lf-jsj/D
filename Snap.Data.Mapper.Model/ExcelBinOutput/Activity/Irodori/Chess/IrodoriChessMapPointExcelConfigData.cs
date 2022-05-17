namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Chess;

public class IrodoriChessMapPointExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("coordX")]
    public double CoordX { get; set; }

    [JsonPropertyName("coordY")]
    public double CoordY { get; set; }
}