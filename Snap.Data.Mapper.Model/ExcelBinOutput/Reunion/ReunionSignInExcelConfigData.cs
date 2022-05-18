namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reunion;

public class ReunionSignInExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dayIndex")]
    public int DayIndex { get; set; }

    [JsonPropertyName("rewardId")]
    public IList<int> RewardId { get; set; } = default!;
}