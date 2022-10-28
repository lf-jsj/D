using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class Costume
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public bool IsDefault { get; set; }
    public string? Icon { get; set; }
    public string? SideIcon { get; set; }
}

public class CookBonus
{
    public string OriginName { get; set; } = default!;
    public string OriginDescription { get; set; } = default!;
    public string OriginIcon { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string EffectDescription { get; set; } = default!;
    public string Icon { get; set; } = default!;
    public int RankLevel { get; set; }
    public List<Item> InputList { get; set; } = default!;
}

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Icon { get; set; } = default!;
    public int RankLevel { get; set; }
    public int Count { get; set; }
}
