using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarCurveExcelConfigData : DataObject
{
    public int Level { get; set; }

    public IList<TypeArithValue> CurveInfos { get; set; } = default!;
}
