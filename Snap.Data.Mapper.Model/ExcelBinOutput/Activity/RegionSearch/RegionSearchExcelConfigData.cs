namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.RegionSearch;

public class RegionSearchExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("searchNameTextMapHash")]
    public Text SearchNameTextMapHash { get; set; }

    [JsonPropertyName("searchDescTextMapHash")]
    public Text SearchDescTextMapHash { get; set; }

    [JsonPropertyName("searchCompleteTextMapHash")]
    public Text SearchCompleteTextMapHash { get; set; }

    [JsonPropertyName("tutorialId")]
    public int TutorialId { get; set; }

    [JsonPropertyName("markIconTypeName")]
    public string MarkIconTypeName { get; set; } = default!;

    [JsonPropertyName("searchType")]
    public string SearchType { get; set; } = default!;

    [JsonPropertyName("searchGroupId")]
    public int SearchGroupId { get; set; }

    [JsonPropertyName("reviseLevel")]
    public int ReviseLevel { get; set; }

    [JsonPropertyName("abilityGroup")]
    public string AbilityGroup { get; set; } = default!;
}