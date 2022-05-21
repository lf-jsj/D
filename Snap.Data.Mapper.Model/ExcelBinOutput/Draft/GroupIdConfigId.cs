namespace Snap.Data.Mapper.Model.ExcelBinOutput.Draft;

public class GroupIdConfigId : DataObject
{
    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }
}
