using Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
using System;
using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class Avatar
{
    public string Body { get; set; } = default!;
    public string Icon { get; set; } = default!;
    public string SideIcon { get; set; } = default!;
    public ItemQuality Quality { get; set; }
    public WeaponType Weapon { get; set; }
    public SkillDepot SkillDepot { get; set; } = default!;
    public PropertyInfo Property { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public DateTimeOffset BeginTime { get; set; }
    public int Sort { get; set; }
    public IEnumerable<Costume> Costumes { get; set; } = default!;
    public FetterInfo FetterInfo { get; set; } = default!;
}
