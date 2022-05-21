namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class QuestSummarizationTextExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("DescTextMapHash")]
    public Text DescTextMapHash { get; set; }
}