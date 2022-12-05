using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ProudSkillExcelConfigData : DataObject
{
    public int ProudSkillId { get; set; }

    public int ProudSkillGroupId { get; set; }

    public int Level { get; set; }

    public int ProudSkillType { get; set; }

    public Text NameTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public Text UnlockDescTextMapHash { get; set; }

    public string Icon { get; set; } = default!;

    public IList<IdCount<int>> CostItems { get; set; } = default!;

    public int BreakLevel { get; set; }

    public IList<Text> ParamDescList { get; set; } = default!;


    public string OpenConfig { get; set; } = default!;

    public IList<PropTypeValue> AddProps { get; set; } = default!;

    public IList<double> ParamList { get; set; } = default!;

    public int CoinCost { get; set; }

    public int EffectiveForTeam { get; set; }
}
