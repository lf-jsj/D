namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gather;

public class Point : DataObject
{
    [JsonPropertyName("pointID")]
    public int PointID { get; set; }

    [JsonPropertyName("pointType")]
    public int PointType { get; set; }

    [JsonPropertyName("offsetX")]
    public double OffsetX { get; set; }

    [JsonPropertyName("offsetY")]
    public double OffsetY { get; set; }

    [JsonPropertyName("offsetZ")]
    public double OffsetZ { get; set; }

    [JsonPropertyName("rotY")]
    public double RotY { get; set; }

    [JsonPropertyName("rotX")]
    public double? RotX { get; set; }

    [JsonPropertyName("rotZ")]
    public double? RotZ { get; set; }
}
