namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityTimeGroupExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("groupIdList")]
    public IList<int> GroupIdList { get; set; } = default!;

    [JsonPropertyName("duration")]
    public IList<int> Duration { get; set; } = default!;
}
