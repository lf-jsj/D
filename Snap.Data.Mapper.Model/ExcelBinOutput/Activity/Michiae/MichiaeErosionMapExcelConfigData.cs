namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeErosionMapExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("HGJKGDEMNGH")]
    public IList<int> HGJKGDEMNGH { get; set; } = default!;

    [JsonPropertyName("MBCCNPBCIMA")]
    public Text MBCCNPBCIMA { get; set; }

    [JsonPropertyName("IFALNDDEKGF")]
    public Text IFALNDDEKGF { get; set; }
}