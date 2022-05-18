namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponLevelExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("requiredExps")]
    public IList<int> RequiredExps { get; set; } = default!;
}