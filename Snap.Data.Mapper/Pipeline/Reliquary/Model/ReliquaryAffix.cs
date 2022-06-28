using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Pipeline.Reliquary.Model;

public class ReliquaryAffix
{
    public int Id { get; set; }
    public FightProperty Type { get; set; }
    public double Value { get; set; }
}
