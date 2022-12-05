using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquaryLevelExcelConfigData : DataObject
{
    public int Level { get; set; }

    public IList<FightPropTypeValue> AddProps { get; set; } = default!;

    public ItemQuality Rank { get; set; }

    public int Exp { get; set; }
}