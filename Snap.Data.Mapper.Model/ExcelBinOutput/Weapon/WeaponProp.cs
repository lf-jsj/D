using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponProp : DataObject
{
    [JsonPropertyName("propType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public FightProperty PropType { get; set; } = default!;

    [JsonPropertyName("initValue")]
    public double InitValue { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; } = default!;
}
