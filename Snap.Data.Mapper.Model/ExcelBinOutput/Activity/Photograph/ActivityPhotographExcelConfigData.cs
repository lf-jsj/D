namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Photograph;

public class ActivityPhotographExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("OECLGEHMJLL")]
    public IList<int> OECLGEHMJLL { get; set; } = default!;

    [JsonPropertyName("CAFAEBHINIB")]
    public IList<int> CAFAEBHINIB { get; set; } = default!;
}
