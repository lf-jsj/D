namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.PlantFlower;

public class ActivityPlantFlowerDailyExcelConfigData : DataObject
{

    [JsonPropertyName("dailyConfigId")]
    public int DailyConfigId { get; set; }

    [JsonPropertyName("costItemList")]
    public IList<CountableItem> CostItemList { get; set; } = default!;

    [JsonPropertyName("rewardIdList")]
    public IList<int> RewardIdList { get; set; } = default!;
}
