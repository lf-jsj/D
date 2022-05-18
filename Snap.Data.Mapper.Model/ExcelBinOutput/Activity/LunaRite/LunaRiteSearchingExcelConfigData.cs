namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LunaRite;

public class LunaRiteSearchingExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("MPPMJCEHDEO")]
    public string MPPMJCEHDEO { get; set; } = default!;

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("OIMGMHMLPFM")]
    public int OIMGMHMLPFM { get; set; }

    [JsonPropertyName("MIIJOHIJPNP")]
    public IList<int> MIIJOHIJPNP { get; set; } = default!;

    [JsonPropertyName("regionCenter")]
    public IList<double> RegionCenter { get; set; } = default!;

    [JsonPropertyName("FIHMKHBDOEM")]
    public Text FIHMKHBDOEM { get; set; }

    [JsonPropertyName("FANMGOBJKKP")]
    public int FANMGOBJKKP { get; set; }

    [JsonPropertyName("regionRadius")]
    public double RegionRadius { get; set; }

    [JsonPropertyName("ANLJEAMNIKH")]
    public int ANLJEAMNIKH { get; set; }

    [JsonPropertyName("ICBLMMAECAA")]
    public int ICBLMMAECAA { get; set; }

    [JsonPropertyName("HNBOLKAMKFH")]
    public int HNBOLKAMKFH { get; set; }

    [JsonPropertyName("ICCJHPHAPJI")]
    public int ICCJHPHAPJI { get; set; }
}