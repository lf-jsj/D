using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Model;

public class JLJPHIAFGOJ
{
    [JsonPropertyName("ELPCOOLNPFF")]
    public string ELPCOOLNPFF { get; set; } = null!;

    [JsonPropertyName("LNJAEIIDNAO")]
    public double LNJAEIIDNAO { get; set; }
}

public class AbilityOverrideExcelConfigData
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("abilityName")]
    public string AbilityName { get; set; } = null!;

    [JsonPropertyName("JLJPHIAFGOJ")]
    public IList<JLJPHIAFGOJ> JLJPHIAFGOJ { get; set; } = null!;

    [JsonPropertyName("FOKEAEJGIOA")]
    public IList<string> FOKEAEJGIOA { get; set; } = null!;

    [JsonPropertyName("KAACPJHILCD")]
    public IList<double> KAACPJHILCD { get; set; } = null!;
}
