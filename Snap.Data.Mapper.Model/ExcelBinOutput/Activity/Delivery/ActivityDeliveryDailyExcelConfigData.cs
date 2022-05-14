namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Delivery;

public class ActivityDeliveryDailyExcelConfigData : DataObject
{
    [JsonPropertyName("dailyConfigId")]
    public int DailyConfigId { get; set; }

    [JsonPropertyName("deliveryQuestConfig")]
    public IList<DeliveryQuestConfig> DeliveryQuestConfig { get; set; } = default!;

    [JsonPropertyName("taskDesc")]
    public IList<Text> TaskDesc { get; set; } = default!;

    [JsonPropertyName("dailyRewardId")]
    public int DailyRewardId { get; set; }
}
