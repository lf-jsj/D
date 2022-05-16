namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BonusActivity;

public class RewardItem : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}
