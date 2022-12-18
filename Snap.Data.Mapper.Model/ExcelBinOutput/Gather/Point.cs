namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gather;

public class Point : DataObject
{
    [JsonPropertyName("pointID")]
    public int PointID { get; set; }

    [JsonPropertyName("pointType")]
    public int PointType { get; set; }

    [JsonPropertyName("offsetX")]
    public float OffsetX { get; set; }

    [JsonPropertyName("offsetY")]
    public float OffsetY { get; set; }

    [JsonPropertyName("offsetZ")]
    public float OffsetZ { get; set; }

    [JsonPropertyName("rotY")]
    public float RotY { get; set; }

    [JsonPropertyName("rotX")]
    public float? RotX { get; set; }

    [JsonPropertyName("rotZ")]
    public float? RotZ { get; set; }
}
