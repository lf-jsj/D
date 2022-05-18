namespace Snap.Data.Mapper.Model.ExcelBinOutput.MiracleRing;
public class MiracleRingDropExcelConfigData : DataObject
{
    [JsonPropertyName("miracleTag")]
    public string MiracleTag { get; set; } = default!;

    [JsonPropertyName("dropId")]
    public IList<int> DropId { get; set; } = default!;
}