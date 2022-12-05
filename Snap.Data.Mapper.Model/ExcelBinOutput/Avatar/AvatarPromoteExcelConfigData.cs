using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarPromoteExcelConfigData : DataObject
{
    public int AvatarPromoteId { get; set; }

    public string PromoteAudio { get; set; } = string.Empty;

    public IList<IdCount<int>> CostItems { get; set; } = default!;

    public int UnlockMaxLevel { get; set; }

    public IList<FightPropTypeValue> AddProps { get; set; } = default!;

    public int? PromoteLevel { get; set; }

    public int? ScoinCost { get; set; }

    public int? RequiredPlayerLevel { get; set; }
}
