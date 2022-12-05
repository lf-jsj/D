using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class EquipAffixExcelConfigData : DataObject
{
    public int AffixId { get; set; }

    public int Id { get; set; }

    public Text NameTextMapHash { get; set; }

    public Text DescTextMapHash { get; set; }

    public string OpenConfig { get; set; } = default!;

    public IList<PropTypeValue> AddProps { get; set; } = default!;

    public IList<double> ParamList { get; set; } = default!;

    public int Level { get; set; }
}