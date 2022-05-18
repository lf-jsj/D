namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;
public class NewActivityAvatarSelectionExcelConfigData : DataObject
{
    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("condId")]
    public int CondId { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("avatarRewardList")]
    public IList<int> AvatarRewardList { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("costItemNum")]
    public IList<int> CostItemNum { get; set; } = default!;

    [JsonPropertyName("MHNOIACBFLA")]
    public IList<int> MHNOIACBFLA { get; set; } = default!;
}