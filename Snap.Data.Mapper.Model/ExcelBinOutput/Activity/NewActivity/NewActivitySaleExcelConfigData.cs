namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivitySaleExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("saleType")]
    public string SaleType { get; set; } = default!;

    [JsonPropertyName("saleParam")]
    public IList<string> SaleParam { get; set; } = default!;

    [JsonPropertyName("bufftipsTextMapHash")]
    public Text BufftipsTextMapHash { get; set; }
}