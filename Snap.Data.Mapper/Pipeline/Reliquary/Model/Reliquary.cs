using Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Reliquary.Model;

public class Reliquary
{
    public IEnumerable<int> Ids { get; set; } = default!;
    public IEnumerable<int> RankLevels { get; set; } = default!;
    public int SetId { get; set; }
    public EquipType EquipType { get; set; } = default!;
    public ItemType ItemType { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Icon { get; set; } = default!;
}
