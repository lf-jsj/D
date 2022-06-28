using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Pipeline.Avatar.Model;

namespace Snap.Data.Mapper.Pipeline.Weapon.Model;

public class Weapon
{
    public int Id { get; set; }
    public WeaponType WeaponType { get; set; }
    public int RankLevel { get; set; }

    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Icon { get; set; } = default!;
    public string AwakenIcon { get; set; } = default!;

    public PropertyInfo Property { get; set; } = default!;
}