namespace Snap.Data.Mapper.Pipeline.Achievement.Model.SnapGenshin;
/// <summary>
/// 成就
/// </summary>
public class SGAchievement
{
    /// <summary>
    /// 大纲Id
    /// </summary>
    public int GoalId { get; set; }

    /// <summary>
    /// 前置成就Id
    /// </summary>
    public int PreStageAchievementId { get; set; }

    /// <summary>
    /// 顺序Id
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 奖励原石个数
    /// </summary>
    public int FinishRewardCount { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
}