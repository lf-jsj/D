using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Pipeline.Avatar.Model;
using System.Collections.Generic;

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
    public AffixInfo? Affix { get; set; } = default!;
}

public class AffixInfo
{
    public string Name { get; set; } = default!;
    public List<AffixLevelDescription> Descriptions { get; set; } = default!;
}

public class AffixLevelDescription
{
    public int Level { get; set; }
    public string Description { get; set; } = default!;
}
