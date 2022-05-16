namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BounceConjuring;

public class BounceConjuringItemExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("bgIconHashSuffix")]
    public HashSuffix BgIconHashSuffix { get; set; }

    [JsonPropertyName("bgIconHashPre")]
    public HashPre BgIconHashPre { get; set; }
}