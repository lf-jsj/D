namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RoguelikeCardExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("MGDKNLDBKAP")]
    public IList<int> MGDKNLDBKAP { get; set; } = default!;

    [JsonPropertyName("ICKLECNOLCO")]
    public IList<string> ICKLECNOLCO { get; set; } = default!;

    [JsonPropertyName("FAELCGMBLMO")]
    public FAELCGMBLMO FAELCGMBLMO { get; set; } = default!;

    [JsonPropertyName("BCGMNJBANBL")]
    public Text BCGMNJBANBL { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("ABNJNLOOJMJ")]
    public Text ABNJNLOOJMJ { get; set; }

    [JsonPropertyName("descParamList")]
    public IList<float> DescParamList { get; set; } = default!;

    [JsonPropertyName("PBLMHJIPEHN")]
    public IList<bool> PBLMHJIPEHN { get; set; } = default!;

    [JsonPropertyName("GKABOOAPMJP")]
    public IList<float> GKABOOAPMJP { get; set; } = default!;

    [JsonPropertyName("EDMDDHJJKAN")]
    public string EDMDDHJJKAN { get; set; } = default!;

    [JsonPropertyName("OJBDKDOGJAK")]
    public bool? OJBDKDOGJAK { get; set; }
}