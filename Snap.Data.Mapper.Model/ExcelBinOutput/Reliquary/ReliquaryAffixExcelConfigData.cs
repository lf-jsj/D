using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
public class ReliquaryAffixExcelConfigData : DataObject
{
    public int Id { get; set; }

    public int DepotId { get; set; }

    public int GroupId { get; set; }

    public FightProperty PropType { get; set; } = default!;

    public double PropValue { get; set; }
}
