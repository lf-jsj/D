namespace Snap.Data.Mapper.Model.ExcelBinOutput.Draft;

public class TransferConfig : DataObject
{
    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }
}
