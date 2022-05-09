namespace Snap.Data.Mapper.Model.ExcelBinOutput.Ability;

public class JLJPHIAFGOJ : DataObject
{
    [JsonPropertyName("ELPCOOLNPFF")]
    public string ELPCOOLNPFF { get; set; } = string.Empty;

    [JsonPropertyName("LNJAEIIDNAO")]
    public double? LNJAEIIDNAO { get; set; }
}

public class AbilityOverrideExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    [PrimaryKey]
    public int Id { get; set; }

    [JsonPropertyName("abilityName")]
    [PrimaryName]
    public string AbilityName { get; set; } = string.Empty;

    [JsonPropertyName("JLJPHIAFGOJ")]
    [DataArray(Length = 5)]
    public IList<JLJPHIAFGOJ> JLJPHIAFGOJ { get; set; } = default!;

    [JsonPropertyName("FOKEAEJGIOA")]
    public IList<string> FOKEAEJGIOA { get; set; } = default!;

    [JsonPropertyName("KAACPJHILCD")]
    public IList<double> KAACPJHILCD { get; set; } = default!;
}
