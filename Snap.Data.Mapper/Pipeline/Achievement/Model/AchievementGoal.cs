namespace Snap.Data.Mapper.Pipeline.Achievement.Model;

public class AchievementGoal
{
    public int Id { get; set; }
    public int Order { get; set; }
    public string Name { get; set; } = default!;
    public SimpleReward? FinishReward { get; set; }
    public string? Icon { get; set; }
}