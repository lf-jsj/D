namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.HideAndSeek;

public class HideAndSeekSkillExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("skillID")]
    public int SkillID { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("skillCategory")]
    public string SkillCategory { get; set; } = default!;

    [JsonPropertyName("skillSubCategory")]
    public string SkillSubCategory { get; set; } = default!;

    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }

    [JsonPropertyName("categoryDescTextMapHash")]
    public Text CategoryDescTextMapHash { get; set; }

    [JsonPropertyName("OGLOGMADIMP")]
    public Text OGLOGMADIMP { get; set; }

    [JsonPropertyName("GMMAIPDCKJI")]
    public int GMMAIPDCKJI { get; set; }
}
