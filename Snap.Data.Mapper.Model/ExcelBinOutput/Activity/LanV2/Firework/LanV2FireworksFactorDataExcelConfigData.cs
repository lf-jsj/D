namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Firework;

public class LanV2FireworksFactorDataExcelConfigData : DataObject
{
    [JsonPropertyName("DIPNOEOPLHP")]
    public int DIPNOEOPLHP { get; set; }

    [JsonPropertyName("CKEMHCNALKM")]
    public IList<int> CKEMHCNALKM { get; set; } = default!;

    [JsonPropertyName("BHLMEPEDMFK")]
    public int BHLMEPEDMFK { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("BNBLINPMBKE")]
    public IList<int> BNBLINPMBKE { get; set; } = default!;
}