namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ReactionEnergyExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("minDurability")]
    public double MinDurability { get; set; }

    [JsonPropertyName("maxDurability")]
    public double MaxDurability { get; set; }

    [JsonPropertyName("costRatio")]
    public double CostRatio { get; set; }

    [JsonPropertyName("configID")]
    public int ConfigID { get; set; }

    [JsonPropertyName("poolSize")]
    public double PoolSize { get; set; }

    [JsonPropertyName("poolRevivePeriod")]
    public double PoolRevivePeriod { get; set; }

    [JsonPropertyName("poolReviveEnergy")]
    public double PoolReviveEnergy { get; set; }

    [JsonPropertyName("isPersistent")]
    public bool IsPersistent { get; set; }

    [JsonPropertyName("costPeriod")]
    public double CostPeriod { get; set; }

    [JsonPropertyName("dropProb")]
    public int DropProb { get; set; }
}