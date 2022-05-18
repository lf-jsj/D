namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusGearLevelUpExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("gearID")]
    public int GearID { get; set; }

    [JsonPropertyName("gearLevel")]
    public int GearLevel { get; set; }

    [JsonPropertyName("gearNameTextMapHash")]
    public Text GearNameTextMapHash { get; set; }

    [JsonPropertyName("gearShortNameTextMapHash")]
    public Text GearShortNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("gearIconPath")]
    public string GearIconPath { get; set; } = default!;

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

    [JsonPropertyName("globalValueParam")]
    public IList<GlobalValueParam> GlobalValueParam { get; set; } = default!;

    [JsonPropertyName("effectList")]
    public IList<int> EffectList { get; set; } = default!;

    [JsonPropertyName("gearLevelUpMoney")]
    public int? GearLevelUpMoney { get; set; }
}