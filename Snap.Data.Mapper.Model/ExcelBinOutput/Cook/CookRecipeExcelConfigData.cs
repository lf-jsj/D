namespace Snap.Data.Mapper.Model.ExcelBinOutput.Cook;

public class CookRecipeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("rankLevel")]
    public int RankLevel { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("effectDesc")]
    public IList<Text> EffectDesc { get; set; } = default!;

    [JsonPropertyName("foodType")]
    public string FoodType { get; set; } = default!;

    [JsonPropertyName("cookMethod")]
    public string CookMethod { get; set; } = default!;

    [JsonPropertyName("isDefaultUnlocked")]
    public bool IsDefaultUnlocked { get; set; }

    [JsonPropertyName("maxProficiency")]
    public int MaxProficiency { get; set; }

    [JsonPropertyName("qualityOutputVec")]
    public IList<CountableItem> QualityOutputVec { get; set; } = default!;

    [JsonPropertyName("inputVec")]
    public IList<CountableItem> InputVec { get; set; } = default!;

    [JsonPropertyName("qteParam")]
    public string QteParam { get; set; } = default!;

    [JsonPropertyName("qteQualityWeightVec")]
    public IList<int> QteQualityWeightVec { get; set; } = default!;
}
