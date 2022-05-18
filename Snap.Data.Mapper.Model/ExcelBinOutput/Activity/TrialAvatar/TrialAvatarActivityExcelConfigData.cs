namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TrialAvatar;

public class TrialAvatarActivityExcelConfigData : DataObject
{
    [JsonPropertyName("ScheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("AvatarIndexIdList")]
    public IList<int> AvatarIndexIdList { get; set; } = default!;

    [JsonPropertyName("RewardIdList")]
    public IList<int> RewardIdList { get; set; } = default!;
}
