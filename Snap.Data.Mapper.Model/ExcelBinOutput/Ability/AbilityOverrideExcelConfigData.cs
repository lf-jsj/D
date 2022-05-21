namespace Snap.Data.Mapper.Model.ExcelBinOutput.Ability;

public class AbilityOverrideExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    [PrimaryKey]
    public int Id { get; set; }

    [JsonPropertyName("abilityName")]
    [PrimaryName]
    public string AbilityName { get; set; } = default!;

    [JsonPropertyName("JLJPHIAFGOJ")]
    [DataArray(Length = 5)]
    public IList<ELPCOOLNPFFLNJAEIIDNAO> JLJPHIAFGOJ { get; set; } = default!;

    [JsonPropertyName("FOKEAEJGIOA")]
    public IList<string> FOKEAEJGIOA { get; set; } = default!;

    [JsonPropertyName("KAACPJHILCD")]
    public IList<double> KAACPJHILCD { get; set; } = default!;
}
