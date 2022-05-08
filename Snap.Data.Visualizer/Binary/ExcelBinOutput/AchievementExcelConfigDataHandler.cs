using Snap.Data.Mapper.Model;

namespace Snap.Data.Visualizer.Binary.ExcelBinOutput;

internal class AchievementExcelConfigDataHandler : TypedExcelOutputHandler<AchievementExcelConfigData>
{
    public AchievementExcelConfigDataHandler(string rootPath)
        : base(rootPath)
    {
    }
}