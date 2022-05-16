namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class GadgetPropExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("hp")]
    public double Hp { get; set; }

    [JsonPropertyName("hpCurve")]
    public string HpCurve { get; set; } = default!;

    [JsonPropertyName("attack")]
    public double Attack { get; set; }

    [JsonPropertyName("attackCurve")]
    public string AttackCurve { get; set; } = default!;

    [JsonPropertyName("defense")]
    public double Defense { get; set; }

    [JsonPropertyName("defenseCurve")]
    public string DefenseCurve { get; set; } = default!;
}