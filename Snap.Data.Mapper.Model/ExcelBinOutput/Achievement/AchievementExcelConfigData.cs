namespace Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;

public class AchievementExcelConfigData : DataObject
{
    public int GoalId { get; set; }

    public int OrderId { get; set; }

    public Text TitleTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public Text Ps5TitleTextMapHash { get; set; }

    public string Ttype { get; set; } = string.Empty;

    public string PsTrophyId { get; set; } = string.Empty;

    public string Ps4TrophyId { get; set; } = string.Empty;

    public string Ps5TrophyId { get; set; } = string.Empty;

    public string? Icon { get; set; }

    public int FinishRewardId { get; set; }

    public bool IsDeleteWatcherAfterFinish { get; set; }

    public int Id { get; set; }

    public int Progress { get; set; }
}
