namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomGadget;

public class CustomGadgetTabExcelConfigData : DataObject
{
    [JsonPropertyName("KLKILCALCLJ")]
    public int KLKILCALCLJ { get; set; }

    [JsonPropertyName("tabNameTextMapHash")]
    public Text TabNameTextMapHash { get; set; }

    [JsonPropertyName("HLGAOPJGGAC")]
    public IList<string> HLGAOPJGGAC { get; set; } = default!;

    [JsonPropertyName("PDBBFLCPMLO")]
    public string PDBBFLCPMLO { get; set; } = default!;

    [JsonPropertyName("ENDBEPMABKM")]
    public string ENDBEPMABKM { get; set; } = default!;

    [JsonPropertyName("LALCBBBAOII")]
    public Text LALCBBBAOII { get; set; }

    [JsonPropertyName("BNHCBKLCPIO")]
    public Text BNHCBKLCPIO { get; set; }

    [JsonPropertyName("DFOBMLLICOA")]
    public int? DFOBMLLICOA { get; set; }
}