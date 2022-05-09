namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class ActivityChessAffixExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public MappedText NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public MappedText DescTextMapHash { get; set; }
}