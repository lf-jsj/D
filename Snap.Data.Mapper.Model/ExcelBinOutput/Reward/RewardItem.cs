namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reward;

public class RewardItem : DataObject
{
    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("itemCount")]
    public int ItemCount { get; set; }
}