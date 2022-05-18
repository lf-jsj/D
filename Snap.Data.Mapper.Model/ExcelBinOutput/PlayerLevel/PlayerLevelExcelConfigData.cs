namespace Snap.Data.Mapper.Model.ExcelBinOutput.PlayerLevel;
public class PlayerLevelExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("exp")]
    public int Exp { get; set; }

    [JsonPropertyName("unlockDescTextMapHash")]
    public Text UnlockDescTextMapHash { get; set; }

    [JsonPropertyName("rewardId")]
    public int? RewardId { get; set; }

    [JsonPropertyName("unlockWorldLevel")]
    public int? UnlockWorldLevel { get; set; }

    [JsonPropertyName("expeditionLimitAdd")]
    public int? ExpeditionLimitAdd { get; set; }
}