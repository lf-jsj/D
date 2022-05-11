namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Spice;

public class ActivitySpiceStageDataExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("AHCOPLCHBHN")]
    public int AHCOPLCHBHN { get; set; }

    [JsonPropertyName("CDPLMDEPMIE")]
    public int CDPLMDEPMIE { get; set; }

    [JsonPropertyName("MFFNPFEDEHF")]
    public IList<int> MFFNPFEDEHF { get; set; } = default!;

    [JsonPropertyName("FCFLHIICMAH")]
    public IList<int> FCFLHIICMAH { get; set; } = default!;

    [JsonPropertyName("GHDHKLEKLGB")]
    public IList<int> GHDHKLEKLGB { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("AOPLOMIFMMC")]
    public double AOPLOMIFMMC { get; set; }

    [JsonPropertyName("times")]
    public int Times { get; set; }

    [JsonPropertyName("HGKAJILNKBK")]
    public int HGKAJILNKBK { get; set; }

    [JsonPropertyName("LKADHFDJCMC")]
    public IList<int> LKADHFDJCMC { get; set; } = default!;

    [JsonPropertyName("watcherId")]
    public int WatcherId { get; set; }
}