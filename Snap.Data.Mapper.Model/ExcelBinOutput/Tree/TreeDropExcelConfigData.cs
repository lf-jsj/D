namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tree;
public class TreeDropExcelConfigData : DataObject
{
    [JsonPropertyName("treeType")]
    public string TreeType { get; set; } = default!;

    [JsonPropertyName("dropId")]
    public int DropId { get; set; }
}
