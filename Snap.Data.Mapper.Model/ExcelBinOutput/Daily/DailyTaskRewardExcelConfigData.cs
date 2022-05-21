using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Daily;

public class DailyTaskRewardExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("dropVec")]
    public IList<DropIdPreviewRewardId> DropVec { get; set; } = default!;
}
