namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LunaRite;

public class LunaRiteQuestExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("chapterIcon")]
    public string ChapterIcon { get; set; } = default!;

    [JsonPropertyName("KOBJNJBIKPC")]
    public Text KOBJNJBIKPC { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("preQuestId")]
    public int? PreQuestId { get; set; }

    [JsonPropertyName("OHLJBKMCGCF")]
    public int? OHLJBKMCGCF { get; set; }

    [JsonPropertyName("POELBNOOLMP")]
    public string POELBNOOLMP { get; set; } = default!;
}