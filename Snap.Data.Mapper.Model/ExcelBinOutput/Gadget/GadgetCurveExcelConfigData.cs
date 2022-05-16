namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class GadgetCurveExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("curveInfos")]
    public IList<CurveInfo> CurveInfos { get; set; }
}
