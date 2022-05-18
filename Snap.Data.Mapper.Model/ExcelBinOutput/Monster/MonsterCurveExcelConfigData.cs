namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterCurveExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("curveInfos")]
    public IList<CurveInfo> CurveInfos { get; set; } = default!;
}