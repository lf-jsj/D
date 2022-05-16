namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;

public class CoopInteractionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("npcId")]
    public int NpcId { get; set; }

    [JsonPropertyName("mainQuestId")]
    public int MainQuestId { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("isAuto")]
    public bool? IsAuto { get; set; }
}
