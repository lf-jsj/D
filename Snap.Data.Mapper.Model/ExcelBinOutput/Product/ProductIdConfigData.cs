namespace Snap.Data.Mapper.Model.ExcelBinOutput.Product;

public class ProductIdConfigData : DataObject
{
    [JsonPropertyName("productId")]
    public string ProductId { get; set; } = default!;

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("isInternal")]
    public bool IsInternal { get; set; }

    [JsonPropertyName("entitlementId")]
    public string EntitlementId { get; set; } = default!;

    [JsonPropertyName("HCDNKMLCBMI")]
    public string HCDNKMLCBMI { get; set; } = default!;

    [JsonPropertyName("NBIJNMBDIPD")]
    public IList<string> NBIJNMBDIPD { get; set; } = default!;
}