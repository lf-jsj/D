namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gather;

public class GatherBundleExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("bundleName")]
    public string BundleName { get; set; } = default!;

    [JsonPropertyName("baseGadgetId")]
    public int BaseGadgetId { get; set; }

    [JsonPropertyName("points")]
    public IList<Point> Points { get; set; } = default!;
}
