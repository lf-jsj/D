namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.WinterCamp;

public class WinterCampSnowmanExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("EENEOHKPFNI")]
    public IList<int> EENEOHKPFNI { get; set; } = default!;

    [JsonPropertyName("groupIdList")]
    public IList<int> GroupIdList { get; set; } = default!;

    [JsonPropertyName("EDBKLJHADJB")]
    public int EDBKLJHADJB { get; set; }
}