﻿namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class Costume
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public bool IsDefault { get; set; }
    public string? Icon { get; set; }
    public string? SideIcon { get; set; }
}
