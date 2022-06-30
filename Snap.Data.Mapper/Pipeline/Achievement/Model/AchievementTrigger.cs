using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Pipeline.Achievement.Model;

public class AchievementTrigger
{
    public AchievementStepType Type { get; set; }
    public string Id { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}