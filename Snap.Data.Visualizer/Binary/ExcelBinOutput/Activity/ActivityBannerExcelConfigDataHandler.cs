using Snap.Data.Mapper.Model.Activity;

namespace Snap.Data.Visualizer.Binary.ExcelBinOutput.Activity;

internal class ActivityBannerExcelConfigDataHandler : TypedExcelOutputHandler<ActivityBannerExcelConfigData>
{
    public ActivityBannerExcelConfigDataHandler(string rootPath)
        : base(rootPath)
    {
    }
}
