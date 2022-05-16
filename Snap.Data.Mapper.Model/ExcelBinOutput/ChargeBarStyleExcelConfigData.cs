namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ChargeBarStyleExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("FMMEGMDILIH")]
    public string FMMEGMDILIH { get; set; } = default!;
}
