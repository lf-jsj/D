namespace Snap.Data.Mapper.Model.ExcelBinOutput.Group;

public class GroupTagExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("GKAKMJIEPCA")]
    public string GKAKMJIEPCA { get; set; } = default!;
}