namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.PlantFlower;

public class CostItem : DataObject
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}

public class ActivityPlantFlowerDailyExcelConfigData : DataObject
{

    [JsonPropertyName("dailyConfigId")]
    public int DailyConfigId { get; set; }

    [JsonPropertyName("costItemList")]
    public IList<CostItem> CostItemList { get; set; } = default!;

    [JsonPropertyName("rewardIdList")]
    public IList<int> RewardIdList { get; set; } = default!;
}
