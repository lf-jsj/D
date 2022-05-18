namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reunion;

public class ReunionScheduleExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activateLevel")]
    public int ActivateLevel { get; set; }

    [JsonPropertyName("firstGiftRewardId")]
    public int FirstGiftRewardId { get; set; }

    [JsonPropertyName("reunionMissionId")]
    public int ReunionMissionId { get; set; }

    [JsonPropertyName("dailySignInId")]
    public int DailySignInId { get; set; }

    [JsonPropertyName("reunionPrivilegeId")]
    public int ReunionPrivilegeId { get; set; }
}