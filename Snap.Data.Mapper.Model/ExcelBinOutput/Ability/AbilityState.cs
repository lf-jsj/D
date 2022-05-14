namespace Snap.Data.Mapper.Model.ExcelBinOutput.Ability;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AbilityState
{
    None = 0,

    // rest of the item's order is not clear
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
