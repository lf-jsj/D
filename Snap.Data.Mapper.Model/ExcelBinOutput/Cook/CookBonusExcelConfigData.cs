namespace Snap.Data.Mapper.Model.ExcelBinOutput.Cook;

public class CookBonusExcelConfigData : DataObject
{
    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("recipeId")]
    public int RecipeId { get; set; }

    [JsonPropertyName("bonusType")]
    public string BonusType { get; set; } = default!;

    [JsonPropertyName("paramVec")]
    public IList<int> ParamVec { get; set; } = default!;

    [JsonPropertyName("complexParamVec")]
    public IList<int> ComplexParamVec { get; set; } = default!;
}
