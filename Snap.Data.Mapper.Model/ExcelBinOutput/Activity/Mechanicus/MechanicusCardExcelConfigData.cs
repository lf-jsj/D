namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusCardExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("costPoints")]
    public int CostPoints { get; set; }

    [JsonPropertyName("cardType")]
    public string CardType { get; set; } = default!;

    [JsonPropertyName("effectID")]
    public int EffectID { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("descParamList")]
    public IList<string> DescParamList { get; set; } = default!;

    [JsonPropertyName("gearId")]
    public int GearId { get; set; }

    [JsonPropertyName("lastRound")]
    public int? LastRound { get; set; }
}