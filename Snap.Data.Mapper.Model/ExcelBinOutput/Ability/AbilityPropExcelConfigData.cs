namespace Snap.Data.Mapper.Model.ExcelBinOutput.Ability;

public class AbilityPropExcelConfigData : DataObject
{
    [JsonPropertyName("propName")]
    [PrimaryName]
    public string PropName { get; set; } = default!;

    [JsonPropertyName("overallMin")]
    public float OverallMin { get; set; }

    [JsonPropertyName("overallMax")]
    public float OverallMax { get; set; }

    [JsonPropertyName("limitTagMin")]
    public float LimitTagMin { get; set; }

    [JsonPropertyName("limitTagMax")]
    public float LimitTagMax { get; set; }

    [JsonPropertyName("succeedOwner")]
    public bool? SucceedOwner { get; set; }
}
