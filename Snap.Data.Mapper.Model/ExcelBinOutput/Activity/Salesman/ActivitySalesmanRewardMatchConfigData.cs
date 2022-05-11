namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salesman;

public class ActivitySalesmanRewardMatchConfigData : DataObject
{
    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("ReoureceType")]
    public string ReoureceType { get; set; } = default!;

    [JsonPropertyName("boxNameTextMapHash")]
    public Text BoxNameTextMapHash { get; set; }
}