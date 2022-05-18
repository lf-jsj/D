namespace Snap.Data.Mapper.Model.ExcelBinOutput.Shop;

public class ShopRotateExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("rotateId")]
    public int RotateId { get; set; }

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("rotateOrder")]
    public int RotateOrder { get; set; }
}