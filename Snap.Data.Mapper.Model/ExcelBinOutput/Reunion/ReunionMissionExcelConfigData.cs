namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reunion;

public class ReunionMissionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("watcherGroupId")]
    public int WatcherGroupId { get; set; }

    [JsonPropertyName("targetScore")]
    public int TargetScore { get; set; }

    [JsonPropertyName("finishRewardId")]
    public int FinishRewardId { get; set; }

    [JsonPropertyName("NBCIJCHHPLI")]
    public IList<int> NBCIJCHHPLI { get; set; } = default!;

    [JsonPropertyName("KNKDCHHIBGI")]
    public IList<int> KNKDCHHIBGI { get; set; } = default!;

    [JsonPropertyName("GPFNAEPFBMG")]
    public IList<int> GPFNAEPFBMG { get; set; } = default!;
}