namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityOverlapExcelConfigData : DataObject
{
    [JsonPropertyName("activityType")]
    public string ActivityType { get; set; } = default!;
}