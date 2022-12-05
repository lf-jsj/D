using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponCurveExcelConfigData : DataObject
{
    public int Level { get; set; }

    public IList<TypeArithValue> CurveInfos { get; set; } = default!;
}