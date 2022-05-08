using Snap.Data.Mapper.Model.Achievement;

namespace Snap.Data.Visualizer.Binary.ExcelBinOutput.Achievement;

internal class AchievementExcelConfigDataHandler : TypedExcelOutputHandler<AchievementExcelConfigData>
{
    public AchievementExcelConfigDataHandler(string rootPath)
        : base(rootPath)
    {
    }
}
