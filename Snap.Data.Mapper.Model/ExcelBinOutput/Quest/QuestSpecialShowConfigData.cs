namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class QuestSpecialShowConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;

    [JsonPropertyName("param1")]
    public int Param1 { get; set; }

    [JsonPropertyName("MOOFHGGIJBF")]
    public Text MOOFHGGIJBF { get; set; }

    [JsonPropertyName("param2")]
    public int? Param2 { get; set; }
}