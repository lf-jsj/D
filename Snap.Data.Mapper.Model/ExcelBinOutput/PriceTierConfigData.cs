namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class PriceTierConfigData : DataObject
{
    [JsonPropertyName("tierName")]
    public string TierName { get; set; } = default!;

    [JsonPropertyName("vipPoint")]
    public int VipPoint { get; set; }
}