namespace Snap.Data.Mapper.Model.ExcelBinOutput.PlayerLevel;

public class PlayerLevelLockExcelConfigData : DataObject
{
    [JsonPropertyName("playerLevelUpperLimit")]
    public int PlayerLevelUpperLimit { get; set; }

    [JsonPropertyName("unlockDescTextMapHash")]
    public Text UnlockDescTextMapHash { get; set; }

    [JsonPropertyName("worldLevel")]
    public int? WorldLevel { get; set; }

    [JsonPropertyName("unlockPlayerLevel")]
    public int? UnlockPlayerLevel { get; set; }

    [JsonPropertyName("unlockMainQuestId")]
    public int? UnlockMainQuestId { get; set; }
}