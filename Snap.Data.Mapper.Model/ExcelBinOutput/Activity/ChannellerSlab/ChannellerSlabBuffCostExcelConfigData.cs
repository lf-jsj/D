namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;
public class ChannellerSlabBuffCostExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("buffQualityType")]
    public string BuffQualityType { get; set; } = default!;

    [JsonPropertyName("buffCost")]
    public int BuffCost { get; set; }

    [JsonPropertyName("itemID")]
    public int ItemID { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}
