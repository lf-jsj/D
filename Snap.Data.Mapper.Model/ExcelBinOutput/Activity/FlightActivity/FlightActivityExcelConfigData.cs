namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FlightActivity;

public class FlightActivityExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("previewRewardId")]
    public int PreviewRewardId { get; set; }

    [JsonPropertyName("startQuestId")]
    public int StartQuestId { get; set; }

    [JsonPropertyName("npcId")]
    public int NpcId { get; set; }

    [JsonPropertyName("medalId")]
    public IList<int> MedalId { get; set; } = default!;

    [JsonPropertyName("dailyFactorVec")]
    public IList<TimeFactorGoldFactor> DailyFactorVec { get; set; } = default!;
}