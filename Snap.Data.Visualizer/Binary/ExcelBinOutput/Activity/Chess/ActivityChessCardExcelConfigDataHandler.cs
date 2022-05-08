using Snap.Data.Mapper.Model.Activity.Chess;

namespace Snap.Data.Visualizer.Binary.ExcelBinOutput.Activity.Chess;

internal class ActivityChessCardExcelConfigDataHandler : TypedExcelOutputHandler<ActivityChessCardExcelConfigData>
{
    public ActivityChessCardExcelConfigDataHandler(string rootPath)
        : base(rootPath)
    {
    }
}