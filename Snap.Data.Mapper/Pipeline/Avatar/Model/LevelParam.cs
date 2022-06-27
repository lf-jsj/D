using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class LevelParam
{
    public int Level { get; set; } = default!;
    public IEnumerable<double> Parameters { get; set; } = default!;
}

public class LevelParam2
{
    public string Level { get; set; } = default!;
    public IEnumerable<double> Parameters { get; set; } = default!;
}