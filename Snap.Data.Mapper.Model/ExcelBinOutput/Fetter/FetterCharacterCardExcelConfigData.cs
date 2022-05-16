namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class FetterCharacterCardExcelConfigData : DataObject
{
    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("fetterLevel")]
    public int FetterLevel { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }
}
