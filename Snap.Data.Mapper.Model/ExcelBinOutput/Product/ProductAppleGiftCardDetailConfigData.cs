using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Product;

public class ProductAppleGiftCardDetailConfigData : DataObject
{
    [JsonPropertyName("contentVec")]
    public IList<MaterialIdMaterialNum> ContentVec { get; set; } = default!;

    [JsonPropertyName("mailConfigId")]
    public int MailConfigId { get; set; }

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("priceTier")]
    public string PriceTier { get; set; } = default!;
}
