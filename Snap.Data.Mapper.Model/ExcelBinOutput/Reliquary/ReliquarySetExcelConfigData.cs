namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquarySetExcelConfigData : DataObject
{
    [JsonPropertyName("setId")]
    public int SetId { get; set; }

    [JsonPropertyName("setIcon")]
    public string SetIcon { get; set; } = default!;

    [JsonPropertyName("setNeedNum")]
    public IList<int> SetNeedNum { get; set; } = default!;

    [JsonPropertyName("EquipAffixId")]
    public int? EquipAffixId { get; set; }

    [JsonPropertyName("containsList")]
    public IList<int> ContainsList { get; set; } = default!;

    [JsonPropertyName("IACBJOIIOMG")]
    public int IACBJOIIOMG { get; set; }

    [JsonPropertyName("DisableFilter")]
    public int? DisableFilter { get; set; }
}