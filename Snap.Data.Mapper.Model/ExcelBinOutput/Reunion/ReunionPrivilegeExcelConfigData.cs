namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reunion;

public class ReunionPrivilegeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dailyNum")]
    public int DailyNum { get; set; }

    [JsonPropertyName("JOPNDDGLFFL")]
    public int JOPNDDGLFFL { get; set; }

    [JsonPropertyName("privilegeType")]
    public IList<PrivilegeType> PrivilegeType { get; set; } = default!;
}