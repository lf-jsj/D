using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class DescParam
{
    public IEnumerable<string> Descriptions { get; set; } = default!;
    public IEnumerable<LevelParam> Parameters { get; set; } = default!;
}
