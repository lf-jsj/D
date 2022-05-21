namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class ActivityUpAvatarExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("avatarIdList")]
    public IList<int> AvatarIdList { get; set; } = default!;
}