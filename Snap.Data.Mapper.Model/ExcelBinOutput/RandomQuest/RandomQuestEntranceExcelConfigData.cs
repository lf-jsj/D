namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class RandomQuestEntranceExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("templateId")]
    public int TemplateId { get; set; }

    [JsonPropertyName("filterList")]
    public IList<Filter> FilterList { get; set; } = default!;

    [JsonPropertyName("filterLogicType")]
    public string FilterLogicType { get; set; } = default!;
}