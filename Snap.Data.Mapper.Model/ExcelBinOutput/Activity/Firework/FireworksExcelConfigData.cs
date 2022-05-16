namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Firework;

public class FireworksExcelConfigData : DataObject
{
    [JsonPropertyName("materialID")]
    public int MaterialID { get; set; }

    [JsonPropertyName("JJPNIBECMEJ")]
    public IList<JJPNIBECMEJ> JJPNIBECMEJ { get; set; } = default!;

    [JsonPropertyName("DCAMKGMJCDF")]
    public string DCAMKGMJCDF { get; set; } = default!;

    [JsonPropertyName("MOFKGBBMNBG")]
    public string MOFKGBBMNBG { get; set; } = default!;

    [JsonPropertyName("AHHOKOPPNLL")]
    public string AHHOKOPPNLL { get; set; } = default!;

    [JsonPropertyName("OJGMMHHBJJK")]
    public Text OJGMMHHBJJK { get; set; }
}
