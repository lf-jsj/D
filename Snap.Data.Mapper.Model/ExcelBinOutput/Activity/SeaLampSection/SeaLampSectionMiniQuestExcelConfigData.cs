namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SeaLampSection;

public class SeaLampSectionMiniQuestExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sectionId")]
    public int SectionId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("miniQuestId")]
    public int MiniQuestId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("isSpecial")]
    public bool? IsSpecial { get; set; }
}