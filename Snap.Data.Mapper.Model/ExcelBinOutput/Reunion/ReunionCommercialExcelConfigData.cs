namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reunion;
public class ReunionCommercialExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("HONMLAGHNMD")]
    public string HONMLAGHNMD { get; set; } = default!;

    [JsonPropertyName("CCIMIPKPCIC")]
    public string CCIMIPKPCIC { get; set; } = default!;
}