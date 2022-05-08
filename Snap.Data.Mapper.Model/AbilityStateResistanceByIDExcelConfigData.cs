namespace Snap.Data.Mapper.Model;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AbilityState
{
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
    None,
    ElementDeadTime,
    ElementRock,
}

public class AbilityStateResistanceByIDExcelConfigData : DataModel
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("abilityStates")]
    public IList<AbilityState> AbilityStates { get; set; } = default!;
}