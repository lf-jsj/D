using System;
using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.GachaEvent;

internal class GachaEvent
{
    public GachaEvent(string version, string name, GachaType type)
    {
        Version = version;
        Name = name;
        Type = type;
    }

    public string Name { get; set; }
    public string Version { get; set; }
    public string Banner { get; set; } = default!;
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
    public GachaType Type { get; set; }

    public List<string> UpOrangeList { get; set; } = default!;
    public List<string> UpPurpleList { get; set; } = default!;
}