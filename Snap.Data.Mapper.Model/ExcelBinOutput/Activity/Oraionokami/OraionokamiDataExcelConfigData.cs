namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Oraionokami;
public class OraionokamiDataExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("NBGGNBANCOC")]
    public int NBGGNBANCOC { get; set; }

    [JsonPropertyName("FGOGFHOCPPN")]
    public int FGOGFHOCPPN { get; set; }

    [JsonPropertyName("serverBuffId")]
    public int ServerBuffId { get; set; }

    [JsonPropertyName("NBGPIJBOEEN")]
    public IList<int> NBGPIJBOEEN { get; set; } = default!;

    [JsonPropertyName("LEPODMIMNME")]
    public Text LEPODMIMNME { get; set; }

    [JsonPropertyName("DDBLAGPFLDP")]
    public Text DDBLAGPFLDP { get; set; }

    [JsonPropertyName("MEGJPJGKHKO")]
    public Text MEGJPJGKHKO { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("CCPNIOLEIDB")]
    public int CCPNIOLEIDB { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;
}