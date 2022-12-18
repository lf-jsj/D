namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LockTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("range")]
    public float Range { get; set; }

    [JsonPropertyName("normalPri")]
    public float? NormalPri { get; set; }

    [JsonPropertyName("combatPri")]
    public float? CombatPri { get; set; }
}
