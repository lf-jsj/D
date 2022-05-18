namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityScoreLimitExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityID")]
    public int ActivityID { get; set; }

    [JsonPropertyName("limitValue")]
    public int LimitValue { get; set; }
}