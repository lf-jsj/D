namespace Snap.Data.Mapper.Model.Activity.Chess;

public class ActivityChessAffixExcelConfigData
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public MappedText NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public MappedText DescTextMapHash { get; set; }
}