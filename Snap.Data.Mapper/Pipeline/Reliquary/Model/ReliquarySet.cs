using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Reliquary.Model;

public class ReliquarySet
{
    public int SetId { get; set; } = default!;
    public IEnumerable<int> NeedNumber { get; set; } = default!;
    public IEnumerable<string> Descriptions { get; set; } = default!;
}