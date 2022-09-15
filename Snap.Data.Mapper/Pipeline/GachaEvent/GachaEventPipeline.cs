using Snap.Data.Mapper.Pipeline.Abstraction;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.GachaEvent;
internal class GachaEventPipeline : IPipeline
{
    private static readonly TimeSpan UTC8 = TimeSpan.FromHours(8);

    private static readonly List<GachaEvent> gachaEvents = new()
    {
        new()
        {
            Type = GachaType.AvatarEventWish,
            UpOrangeList = {"温迪"},
            UpBlueList = { "芭芭拉", "菲谢尔", "香菱" },
            From = new(2020, 9, 28, 6, 0, 0, UTC8),
            To = new(2020, 10, 18, 17, 59, 59, UTC8),
            Name = "杯装之诗",
        },
    };

    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IPipeline.GenerateFile<GachaEvent>(gachaEvents, outputFolder, options);
    }
}
internal class GachaEvent
{
    public string Name { get; set; } = default!;
    public DateTimeOffset From { get; set; }
    public DateTimeOffset To { get; set; }
    public GachaType Type { get; set; }

    public List<string> UpOrangeList { get; set; } = default!;
    public List<string> UpBlueList { get; set; } = default!;
}

/// <summary>
/// 祈愿配置类型
/// </summary>
public enum GachaType
{
    /// <summary>
    /// 新手池
    /// </summary>
    NoviceWish = 100,

    /// <summary>
    /// 常驻池
    /// </summary>
    PermanentWish = 200,

    /// <summary>
    /// 角色1池
    /// </summary>
    AvatarEventWish = 301,

    /// <summary>
    /// 武器池
    /// </summary>
    WeaponEventWish = 302,

    /// <summary>
    /// 角色2池
    /// </summary>
    AvatarEventWish2 = 400,
}