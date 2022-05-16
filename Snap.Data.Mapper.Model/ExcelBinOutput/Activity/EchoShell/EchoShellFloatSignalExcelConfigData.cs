namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.EchoShell;

public class EchoShellFloatSignalExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }
}