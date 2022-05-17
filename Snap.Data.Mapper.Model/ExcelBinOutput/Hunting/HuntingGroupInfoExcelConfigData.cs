namespace Snap.Data.Mapper.Model.ExcelBinOutput.Hunting;

public class HuntingGroupInfoExcelConfigData : DataObject
{
    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("regionId")]
    public int RegionId { get; set; }

    [JsonPropertyName("pointType")]
    public string PointType { get; set; } = default!;

    [JsonPropertyName("refIndex")]
    public IList<int> RefIndex { get; set; } = default!;

    [JsonPropertyName("posType")]
    public string PosType { get; set; } = default!;
}