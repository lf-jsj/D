using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarTalentExcelConfigData : DataObject
{
    public int TalentId { get; set; }

    public Text NameTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public string Icon { get; set; } = default!;

    public int MainCostItemId { get; set; }

    public int MainCostItemCount { get; set; }

    public string OpenConfig { get; set; } = default!;

    public IList<PropTypeValue> AddProps { get; set; } = default!;

    public IList<double> ParamList { get; set; } = default!;

    public int? PrevTalent { get; set; }
}
