namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class ActivityChessGearExcelConfigData : DataObject
{
    [JsonPropertyName("gearID")]
    public int GearID { get; set; }

    [JsonPropertyName("gearNameTextMapHash")]
    public Text GearNameTextMapHash { get; set; }

    [JsonPropertyName("gearShortNameTextMapHash")]
    public Text GearShortNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("gearIconPath")]
    public string GearIconPath { get; set; } = default!;

    [JsonPropertyName("GCHFGPIHLEP")]
    public string GCHFGPIHLEP { get; set; } = default!;

    [JsonPropertyName("attack")]
    public int Attack { get; set; }

    [JsonPropertyName("attackSpeed")]
    public int AttackSpeed { get; set; }

    [JsonPropertyName("attackRange")]
    public int AttackRange { get; set; }

    [JsonPropertyName("buildCost")]
    public int BuildCost { get; set; }

    [JsonPropertyName("demolitionRefund")]
    public int DemolitionRefund { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("NPIDMCDCIAL")]
    public IList<int> NPIDMCDCIAL { get; set; } = default!;

    [JsonPropertyName("DJIGCOELMCK")]
    public int DJIGCOELMCK { get; set; }

    [JsonPropertyName("PGLJHNFKFNG")]
    public int PGLJHNFKFNG { get; set; }

    [JsonPropertyName("isEnableRotate")]
    public bool? IsEnableRotate { get; set; }

    [JsonPropertyName("NADOHIECJML")]
    public int? NADOHIECJML { get; set; }
}
