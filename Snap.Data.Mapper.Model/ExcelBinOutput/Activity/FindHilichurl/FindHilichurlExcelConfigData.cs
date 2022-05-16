namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FindHilichurl;

public class FindHilichurlExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("guideQuestId")]
    public int GuideQuestId { get; set; }

    [JsonPropertyName("endQuestId")]
    public int EndQuestId { get; set; }

    [JsonPropertyName("assignmentIdList")]
    public IList<int> AssignmentIdList { get; set; } = default!;

    [JsonPropertyName("HiliWeiIdList")]
    public IList<int> HiliWeiIdList { get; set; } = default!;
}
