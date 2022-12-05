namespace Snap.Data.Mapper.Model.ExcelBinOutput.Cook;

public class CookBonusExcelConfigData : DataObject
{
    public int AvatarId { get; set; }

    public int RecipeId { get; set; }

    public int BonusType { get; set; }

    [JsonPropertyName("paramVec")]
    public IList<int> ParamVec { get; set; } = default!;

    [JsonPropertyName("complexParamVec")]
    public IList<int> ComplexParamVec { get; set; } = default!;
}
