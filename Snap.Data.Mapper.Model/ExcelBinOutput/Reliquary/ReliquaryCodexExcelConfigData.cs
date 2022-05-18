namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquaryCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("suitId")]
    public int SuitId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("cupId")]
    public int CupId { get; set; }

    [JsonPropertyName("leatherId")]
    public int LeatherId { get; set; }

    [JsonPropertyName("capId")]
    public int CapId { get; set; }

    [JsonPropertyName("flowerId")]
    public int FlowerId { get; set; }

    [JsonPropertyName("sandId")]
    public int SandId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }
}