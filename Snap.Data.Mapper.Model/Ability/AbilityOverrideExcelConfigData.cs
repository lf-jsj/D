namespace Snap.Data.Mapper.Model.Ability;

public class JLJPHIAFGOJ : DataModel
{
    [JsonPropertyName("ELPCOOLNPFF")]
    public string ELPCOOLNPFF { get; set; } = string.Empty;

    [JsonPropertyName("LNJAEIIDNAO")]
    public double? LNJAEIIDNAO { get; set; }
}

public class AbilityOverrideExcelConfigData : DataModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("abilityName")]
    public string AbilityName { get; set; } = string.Empty;

    [JsonPropertyName("JLJPHIAFGOJ")]
    [DataArray(Length = 5)]
    public IList<JLJPHIAFGOJ> JLJPHIAFGOJ { get; set; } = default!;

    [JsonPropertyName("FOKEAEJGIOA")]
    public IList<string> FOKEAEJGIOA { get; set; } = default!;

    [JsonPropertyName("KAACPJHILCD")]
    public IList<double> KAACPJHILCD { get; set; } = default!;
}
