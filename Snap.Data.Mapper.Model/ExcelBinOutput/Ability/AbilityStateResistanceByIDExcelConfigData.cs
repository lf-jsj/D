namespace Snap.Data.Mapper.Model.ExcelBinOutput.Ability;

public class AbilityStateResistanceByIDExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    [PrimaryKey]
    public int Id { get; set; }

    [JsonPropertyName("abilityStates")]
    [DataArray(Length = 10)]
    public IList<AbilityState> AbilityStates { get; set; } = default!;
}