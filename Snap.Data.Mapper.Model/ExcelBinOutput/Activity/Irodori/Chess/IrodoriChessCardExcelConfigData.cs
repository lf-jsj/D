namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Chess;

public class IrodoriChessCardExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("costPoints")]
    public int CostPoints { get; set; }

    [JsonPropertyName("NFOAKLIOPMH")]
    public NFOAKLIOPMH NFOAKLIOPMH { get; set; } = default!;

    [JsonPropertyName("PLDAMHDHOLO")]
    public IList<PLDAMHDHOLO> PLDAMHDHOLO { get; set; } = default!;

    [JsonPropertyName("cardType")]
    public string CardType { get; set; } = default!;

    [JsonPropertyName("IOHHOMNCMBJ")]
    public string IOHHOMNCMBJ { get; set; } = default!;

    [JsonPropertyName("BCGMNJBANBL")]
    public Text BCGMNJBANBL { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("descParam")]
    public IList<double> DescParam { get; set; } = default!;

    [JsonPropertyName("HPKKLACDOAL")]
    public IList<HPKKLACDOAL> HPKKLACDOAL { get; set; } = default!;

    [JsonPropertyName("OPPLAFJOCAM")]
    public string OPPLAFJOCAM { get; set; } = default!;
}