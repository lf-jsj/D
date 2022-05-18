namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponProp : DataObject
{
    [JsonPropertyName("propType")]
    public string PropType { get; set; } = default!;

    [JsonPropertyName("initValue")]
    public double InitValue { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}
