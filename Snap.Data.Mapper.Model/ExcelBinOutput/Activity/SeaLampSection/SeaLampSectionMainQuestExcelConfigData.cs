namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SeaLampSection;

public class SeaLampSectionMainQuestExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("questId")]
    public IList<int> QuestId { get; set; } = default!;

    [JsonPropertyName("introTextMapHash")]
    public Text IntroTextMapHash { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }
}