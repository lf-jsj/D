namespace Snap.Data.Mapper.Model.ExcelBinOutput.Ability;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AbilityState
{
    None = 0,
    ElementFreeze,
    ElementBurning,
    ElementWet,
    ElementFrozen,
    ElementShock,
    ElementFire,
    ElementIce,
    ElementElectric,
    ElementWind,
    ElementPetrifaction,
    Struggle,
    DefenseDown,
    SpeedDown,
    MuteTaunt,
    ElementDeadTime,
    ElementRock,
}

public class AbilityStateResistanceByIDExcelConfigData : DataObject
{

    [JsonPropertyName("id")]
    [PrimaryKey]
    public int Id { get; set; }

    [JsonPropertyName("abilityStates")]
    [DataArray(Length = 10)]
    public IList<AbilityState> AbilityStates { get; set; } = default!;
}