namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salesman;

public class SpecialReward : DataObject
{
    [JsonPropertyName("obtainParam")]
    public string ObtainParam { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("rewardType")]
    public string? RewardType { get; set; }

    [JsonPropertyName("obtainMethod")]
    public string? ObtainMethod { get; set; }

    [JsonPropertyName("previewId")]
    public int? PreviewId { get; set; }
}
