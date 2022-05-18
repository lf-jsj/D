namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reunion;

public class PrivilegeType : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("subType")]
    public string SubType { get; set; } = default!;
}
