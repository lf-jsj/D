namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LockTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("range")]
    public double Range { get; set; }

    [JsonPropertyName("normalPri")]
    public double? NormalPri { get; set; }

    [JsonPropertyName("combatPri")]
    public double? CombatPri { get; set; }
}