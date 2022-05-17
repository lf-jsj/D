namespace Snap.Data.Mapper.Model.ExcelBinOutput.LevelTag;

public class LevelTagGroupsExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("FFAECJAHKOB")]
    public IList<FFAECJAHKOB> FFAECJAHKOB { get; set; } = default!;

    [JsonPropertyName("MCPOHPBPDHC")]
    public IList<int> MCPOHPBPDHC { get; set; } = default!;

    [JsonPropertyName("EAHNJPLOINF")]
    public int EAHNJPLOINF { get; set; }
}