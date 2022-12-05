using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Cook;

public class CookRecipeExcelConfigData : DataObject
{
    public int Id { get; set; }

    public Text NameTextMapHash { get; set; }

    public int RankLevel { get; set; }

    public string Icon { get; set; } = default!;

    public Text DescTextMapHash { get; set; }

    public IList<Text> EffectDesc { get; set; } = default!;

    public int FoodType { get; set; } = default!;

    public int CookMethod { get; set; } = default!;

    public bool IsDefaultUnlocked { get; set; }

    public int MaxProficiency { get; set; }

    public IList<IdCount<int>> QualityOutputVec { get; set; } = default!;

    public IList<IdCount<int>> InputVec { get; set; } = default!;

    public string QteParam { get; set; } = default!;

    public IList<int> QteQualityWeightVec { get; set; } = default!;
}
