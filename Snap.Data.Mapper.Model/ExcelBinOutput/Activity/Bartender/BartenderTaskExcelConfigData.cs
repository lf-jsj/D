namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Bartender;

public class BartenderTaskExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("LKFNFPEJPJA")]
    public int LKFNFPEJPJA { get; set; }

    [JsonPropertyName("parentQuestId")]
    public int ParentQuestId { get; set; }

    [JsonPropertyName("BLFOOHAKHKO")]
    public int BLFOOHAKHKO { get; set; }

    [JsonPropertyName("NGPHBAPMODL")]
    public int NGPHBAPMODL { get; set; }

    [JsonPropertyName("PDCEPCOOOLK")]
    public int PDCEPCOOOLK { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}