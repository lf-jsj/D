namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SignIn;

public class RewardItem : DataObject
{
    [JsonPropertyName("ItemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("Quality")]
    public int Quality { get; set; }
}
