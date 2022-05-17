namespace Snap.Data.Mapper.Model.ExcelBinOutput.Hunting;
public class HuntingClueGatherExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("gatherId")]
    public int GatherId { get; set; }

    [JsonPropertyName("gatherGroupId")]
    public int GatherGroupId { get; set; }

    [JsonPropertyName("isClueGather")]
    public bool IsClueGather { get; set; }
}
