namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Tanuki;

public class ActivityTanukiTravelDataExcelConfigData : DataObject
{

    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("guideQuestId")]
    public int GuideQuestId { get; set; }

    [JsonPropertyName("DGNBFPHLJIJ")]
    public IList<int> DGNBFPHLJIJ { get; set; } = default!;

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("JPOAJJFMGIO")]
    public int JPOAJJFMGIO { get; set; }

    [JsonPropertyName("MJPPMJDKMLE")]
    public int MJPPMJDKMLE { get; set; }

    [JsonPropertyName("LJBMJNDFBFF")]
    public IList<int> LJBMJNDFBFF { get; set; } = default!;

    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }
}
