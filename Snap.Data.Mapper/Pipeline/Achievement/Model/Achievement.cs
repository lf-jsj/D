using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Achievement.Model;

public class Achievement
{
    public int Id { get; set; }
    public int Goal { get; set; }
    public int Order { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public SimpleReward FinishReward { get; set; } = default!;
    public int Progress { get; set; }
    public IEnumerable<AchievementTrigger>? Triggers { get; set; }
    public string? Icon { get; set; }
}