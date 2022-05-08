using Snap.Data.Mapper.Model.Achievement;

namespace Snap.Data.Visualizer.Binary.ExcelBinOutput.Achievement;

internal class AchievementGoalExcelConfigDataHandler : TypedExcelOutputHandler<AchievementGoalExcelConfigData>
{
    public AchievementGoalExcelConfigDataHandler(string rootPath)
        : base(rootPath)
    {
    }
}
