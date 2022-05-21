using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.Common.Wrapper;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class CombineExcelConfigData : DataObject
{
    [JsonPropertyName("combineId")]
    public int CombineId { get; set; }

    [JsonPropertyName("playerLevel")]
    public int PlayerLevel { get; set; }

    [JsonPropertyName("isDefaultShow")]
    public bool IsDefaultShow { get; set; }

    [JsonPropertyName("combineType")]
    public int CombineType { get; set; }

    [JsonPropertyName("subCombineType")]
    public int SubCombineType { get; set; }

    [JsonPropertyName("resultItemId")]
    public int ResultItemId { get; set; }

    [JsonPropertyName("resultItemCount")]
    public int ResultItemCount { get; set; }

    [JsonPropertyName("scoinCost")]
    public int ScoinCost { get; set; }

    [JsonPropertyName("randomItems")]
    public IList<CountWrapper> RandomItems { get; set; } = default!;

    [JsonPropertyName("materialItems")]
    public IList<IdCount<int>> MaterialItems { get; set; } = default!;

    [JsonPropertyName("effectDescTextMapHash")]
    public Text EffectDescTextMapHash { get; set; }

    [JsonPropertyName("recipeType")]
    public string RecipeType { get; set; } = default!;
}
