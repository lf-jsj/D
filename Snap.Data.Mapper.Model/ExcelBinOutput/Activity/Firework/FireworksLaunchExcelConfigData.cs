namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Firework;

public class FireworksLaunchExcelConfigData : DataObject
{
    [JsonPropertyName("ICKBNALLPBM")]
    public string ICKBNALLPBM { get; set; } = default!;

    [JsonPropertyName("defaultValue")]
    public int DefaultValue { get; set; }

    [JsonPropertyName("MPEAOECAFPD")]
    public IList<int> MPEAOECAFPD { get; set; } = default!;

    [JsonPropertyName("DKLONJKAEOP")]
    public int DKLONJKAEOP { get; set; }

    [JsonPropertyName("GBPIIGKLLOE")]
    public Text GBPIIGKLLOE { get; set; }
}