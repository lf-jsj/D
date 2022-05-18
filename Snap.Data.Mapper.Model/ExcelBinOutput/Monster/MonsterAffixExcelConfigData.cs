namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;
public class MonsterAffixExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("affix")]
    public string Affix { get; set; } = default!;

    [JsonPropertyName("comment")]
    public string Comment { get; set; } = default!;

    [JsonPropertyName("abilityName")]
    public IList<string> AbilityName { get; set; } = default!;

    [JsonPropertyName("isLegal")]
    public string IsLegal { get; set; } = default!;

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;

    [JsonPropertyName("generalSkillIcon")]
    public string GeneralSkillIcon { get; set; } = default!;

    [JsonPropertyName("isCommon")]
    public bool? IsCommon { get; set; }

    [JsonPropertyName("preAdd")]
    public bool? PreAdd { get; set; }
}
