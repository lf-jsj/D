using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Reliquary.Model;

public class ReliquarySet
{
    public int SetId { get; set; }
    public int EquipAffixId { get; set; }
    public IEnumerable<int> NeedNumber { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Icon { get; set; } = default!;
    public IEnumerable<string> Descriptions { get; set; } = default!;
}