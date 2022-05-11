namespace Snap.Data.Mapper.Model.ExcelBinOutput.Ability;

public class AbilityPropExcelConfigData : DataObject
{

    [JsonPropertyName("propName")]
    [PrimaryName]
    public string PropName { get; set; } = default!;

    [JsonPropertyName("overallMin")]
    public double OverallMin { get; set; }

    [JsonPropertyName("overallMax")]
    public double OverallMax { get; set; }

    [JsonPropertyName("limitTagMin")]
    public double LimitTagMin { get; set; }

    [JsonPropertyName("limitTagMax")]
    public double LimitTagMax { get; set; }

    [JsonPropertyName("succeedOwner")]
    public bool? SucceedOwner { get; set; }
}
