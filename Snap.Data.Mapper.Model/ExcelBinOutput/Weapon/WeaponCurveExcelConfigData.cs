namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponCurveExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("curveInfos")]
    public IList<CurveInfo> CurveInfos { get; set; } = default!;
}