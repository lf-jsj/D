namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tree;

public class TreeTypeExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("treePattern")]
    public string TreePattern { get; set; } = default!;

    [JsonPropertyName("treeType")]
    public string TreeType { get; set; } = default!;
}