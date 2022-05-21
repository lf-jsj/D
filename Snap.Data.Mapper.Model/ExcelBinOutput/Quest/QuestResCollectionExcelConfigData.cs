namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class QuestResCollectionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("MOGMCFLIGHC")]
    public bool? MOGMCFLIGHC { get; set; }
}