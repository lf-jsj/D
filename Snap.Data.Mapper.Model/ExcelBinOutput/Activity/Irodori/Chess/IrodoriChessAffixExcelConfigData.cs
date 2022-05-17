namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Chess;
public class IrodoriChessAffixExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}
