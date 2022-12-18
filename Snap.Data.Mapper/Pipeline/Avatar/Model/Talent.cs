using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class Talent
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Icon { get; set; } = default!;
}

public class GrowCurveInfo
{
    public int Level { get; set; }
    public Dictionary<string, float> Info { get; set; } = default!;
}