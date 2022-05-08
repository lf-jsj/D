using Snap.Data.Mapper.Model;

namespace Snap.Data.Visualizer.Binary.ExcelBinOutput;

internal class AbilityStateResistanceByIDExcelConfigDataHandler : TypedExcelOutputHandler<AbilityStateResistanceByIDExcelConfigData>
{
    public AbilityStateResistanceByIDExcelConfigDataHandler(string rootPath)
        : base(rootPath)
    {
    }
}