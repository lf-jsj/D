namespace Snap.Data.Mapper.Model.Activity;

public class ActivityAbilityGroupExcelConfigData
{
    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    //TODO: link up avatar id
    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public MappedText NameTextMapHash { get; set; }

    //TODO: link up weapon id
    [JsonPropertyName("weaponId")]
    public int? WeaponId { get; set; }
}
