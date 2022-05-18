namespace Snap.Data.Mapper.Model.ExcelBinOutput.Product;

public class ProductPS4PackageDetailConfigData : DataObject
{
    [JsonPropertyName("contentVec")]
    public IList<ContentVec> ContentVec { get; set; } = default!;

    [JsonPropertyName("mailConfigId")]
    public int MailConfigId { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("priceTier")]
    public string PriceTier { get; set; } = default!;
}