using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquaryMainPropExcelConfigData : DataObject
{
    public int Id { get; set; }

    public FightProperty PropType { get; set; } = default!;
}