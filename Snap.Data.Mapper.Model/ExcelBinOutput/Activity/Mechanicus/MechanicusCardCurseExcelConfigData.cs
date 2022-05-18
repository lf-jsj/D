namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusCardCurseExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("effectID")]
    public int EffectID { get; set; }

    [JsonPropertyName("lastRound")]
    public int LastRound { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("descParamList")]
    public IList<string> DescParamList { get; set; } = default!;
}