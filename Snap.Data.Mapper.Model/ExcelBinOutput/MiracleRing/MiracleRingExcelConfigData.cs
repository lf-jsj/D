namespace Snap.Data.Mapper.Model.ExcelBinOutput.MiracleRing;

public class MiracleRingExcelConfigData : DataObject
{
    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("miracleValue")]
    public int MiracleValue { get; set; }

    [JsonPropertyName("miracleTag")]
    public IList<string> MiracleTag { get; set; } = default!;
}