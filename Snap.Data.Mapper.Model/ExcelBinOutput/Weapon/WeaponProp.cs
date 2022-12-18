using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weapon;

public class WeaponProp : DataObject
{
    [JsonPropertyName("propType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public FightProperty PropType { get; set; } = default!;

    [JsonPropertyName("initValue")]
    public float InitValue { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}
