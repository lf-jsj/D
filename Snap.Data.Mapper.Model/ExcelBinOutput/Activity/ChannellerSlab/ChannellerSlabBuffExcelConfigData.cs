namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabBuffExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("buffNameTextMapHash")]
    public Text BuffNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("descParam")]
    public IList<string> DescParam { get; set; } = default!;

    [JsonPropertyName("materialID")]
    public int MaterialID { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("buffQualityType")]
    public string BuffQualityType { get; set; } = default!;
}