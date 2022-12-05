using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponPromoteExcelConfigData : DataObject
{
    public int WeaponPromoteId { get; set; }

    public IList<IdCount<int>> CostItems { get; set; } = default!;

    public IList<FightPropTypeValue> AddProps { get; set; } = default!;

    public int UnlockMaxLevel { get; set; }

    public int PromoteLevel { get; set; }

    public int RequiredPlayerLevel { get; set; }

    public int CoinCost { get; set; }
}