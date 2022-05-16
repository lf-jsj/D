namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Dig;

public class DigGroupLinkExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("LCMPCOFEKIG")]
    public int LCMPCOFEKIG { get; set; }

    [JsonPropertyName("JJFEAEMLIOM")]
    public int JJFEAEMLIOM { get; set; }

    [JsonPropertyName("NGJIMHEEBHH")]
    public Text NGJIMHEEBHH { get; set; }

    [JsonPropertyName("MIIJOHIJPNP")]
    public IList<int> MIIJOHIJPNP { get; set; } = default!;

    [JsonPropertyName("HOIFIKEFBAH")]
    public string HOIFIKEFBAH { get; set; } = default!;

    [JsonPropertyName("KDAOIEIBBGG")]
    public int? KDAOIEIBBGG { get; set; }

    [JsonPropertyName("FCONIEGFGHE")]
    public int? FCONIEGFGHE { get; set; }
}
