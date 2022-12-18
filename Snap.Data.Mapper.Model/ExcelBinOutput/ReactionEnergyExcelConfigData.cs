namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ReactionEnergyExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("minDurability")]
    public float MinDurability { get; set; }

    [JsonPropertyName("maxDurability")]
    public float MaxDurability { get; set; }

    [JsonPropertyName("costRatio")]
    public float CostRatio { get; set; }

    [JsonPropertyName("configID")]
    public int ConfigID { get; set; }

    [JsonPropertyName("poolSize")]
    public float PoolSize { get; set; }

    [JsonPropertyName("poolRevivePeriod")]
    public float PoolRevivePeriod { get; set; }

    [JsonPropertyName("poolReviveEnergy")]
    public float PoolReviveEnergy { get; set; }

    [JsonPropertyName("isPersistent")]
    public bool IsPersistent { get; set; }

    [JsonPropertyName("costPeriod")]
    public float CostPeriod { get; set; }

    [JsonPropertyName("dropProb")]
    public int DropProb { get; set; }
}