using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class SkillDepot
{
    public SkillInfo EnergySkill { get; set; } = default!;
    public IEnumerable<SkillInfo> Skills { get; set; } = default!;
    public IEnumerable<Talent> Talents { get; set; } = default!;
    public IEnumerable<SkillInfo> Inherents { get; set; } = default!;
}
