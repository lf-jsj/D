namespace Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
public class AchievementGoalExcelConfigData : DataObject
{
    public int OrderId { get; set; }

    public Text NameTextMapHash { get; set; }

    public string IconPath { get; set; } = default!;

    public int Id { get; set; }

    public int FinishRewardId { get; set; }
}