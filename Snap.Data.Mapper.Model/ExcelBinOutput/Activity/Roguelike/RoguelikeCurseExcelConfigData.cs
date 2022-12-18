namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RoguelikeCurseExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("KOIMOIOBOJB")]
    public Text KOIMOIOBOJB { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("FAELCGMBLMO")]
    public FAELCGMBLMO FAELCGMBLMO { get; set; } = default!;

    [JsonPropertyName("OJBDKDOGJAK")]
    public bool OJBDKDOGJAK { get; set; }

    [JsonPropertyName("descParamList")]
    public IList<float> DescParamList { get; set; } = default!;

    [JsonPropertyName("PBLMHJIPEHN")]
    public IList<bool> PBLMHJIPEHN { get; set; } = default!;
}