namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.HideAndSeek;

public class HideAndSeekAvatarSDExcelConfigData : DataObject
{
    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}
