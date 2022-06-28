using Snap.Data.Mapper.Model.Common;
using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class PropertyInfo
{
    public IEnumerable<FightProperty> Properties { get; set; } = default!;
    public IEnumerable<LevelParam2> Parameters { get; set; } = default!;
}