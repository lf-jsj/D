namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Potion;

public class ActivityPotionBuffExcelConfigData : DataObject
{
    [JsonPropertyName("buffId")]
    public int BuffId { get; set; }

    [JsonPropertyName("FGJONOJPIBD")]
    public string FGJONOJPIBD { get; set; } = default!;

    [JsonPropertyName("FFCIPMIMKMD")]
    public int FFCIPMIMKMD { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("descParam")]
    public IList<string> DescParam { get; set; } = default!;

    [JsonPropertyName("FKBPMLNFGPN")]
    public Text FKBPMLNFGPN { get; set; }

    [JsonPropertyName("BIOMKJGHBAK")]
    public int BIOMKJGHBAK { get; set; }

    [JsonPropertyName("EJDPGJFLGLH")]
    public string EJDPGJFLGLH { get; set; } = default!;
}
