namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;
public class WeaponCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("weaponId")]
    public int WeaponId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    [JsonPropertyName("showOnlyUnlocked")]
    public bool? ShowOnlyUnlocked { get; set; }
}
