namespace Snap.Data.Mapper.Model.ExcelBinOutput.Routine;

public class RoutineTypeExcelConfigData : DataObject
{
    [JsonPropertyName("routineType")]
    public string RoutineType { get; set; } = default!;

    [JsonPropertyName("refreshNum")]
    public int RefreshNum { get; set; }

    [JsonPropertyName("rewardLimitNum")]
    public int RewardLimitNum { get; set; }

    [JsonPropertyName("refreshId")]
    public int RefreshId { get; set; }

    [JsonPropertyName("delayUnloadTime")]
    public int DelayUnloadTime { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public int NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public long DescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;
}