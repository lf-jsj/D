using Snap.Data.Mapper.Converter.ObjectModel;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class ActivityAbilityGroupExcelConfigData : DataObject
{
    [JsonPropertyName("index")]
    [PrimaryKey]
    public int Index { get; set; }

    [JsonPropertyName("activityId")]
    [ForeignKey]
    public int ActivityId { get; set; }

    //TODO: link up avatar id
    [JsonPropertyName("avatarId")]
    [ForeignKey]
    public int AvatarId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    //TODO: link up weapon id
    [JsonPropertyName("weaponId")]
    [ForeignKey]
    public int? WeaponId { get; set; }
}
