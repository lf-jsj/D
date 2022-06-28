using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponPromoteExcelConfigData : DataObject
{
    [JsonPropertyName("weaponPromoteId")]
    public int WeaponPromoteId { get; set; }

    [JsonPropertyName("costItems")]
    public IList<IdCount<int>> CostItems { get; set; } = default!;

    [JsonPropertyName("addProps")]
    public IList<FightPropTypeValue> AddProps { get; set; } = default!;

    [JsonPropertyName("unlockMaxLevel")]
    public int UnlockMaxLevel { get; set; }

    [JsonPropertyName("promoteLevel")]
    public int? PromoteLevel { get; set; }

    [JsonPropertyName("requiredPlayerLevel")]
    public int? RequiredPlayerLevel { get; set; }

    [JsonPropertyName("coinCost")]
    public int? CoinCost { get; set; }
}