using Snap.Data.Mapper.Model.Common.Param;

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
    public IList<TypeSubType> PrivilegeType { get; set; } = default!;
}