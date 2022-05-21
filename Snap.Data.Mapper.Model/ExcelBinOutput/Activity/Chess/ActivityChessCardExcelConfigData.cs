namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class ActivityChessCardExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("PMIHFKKMOML")]
    public int PMIHFKKMOML { get; set; }

    [JsonPropertyName("IOHHOMNCMBJ")]
    public string? IOHHOMNCMBJ { get; set; }

    [JsonPropertyName("PGLJHNFKFNG")]
    public int PGLJHNFKFNG { get; set; }

    [JsonPropertyName("BCGMNJBANBL")]
    public Text BCGMNJBANBL { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("ABNJNLOOJMJ")]
    public Text ABNJNLOOJMJ { get; set; }

    [JsonPropertyName("PLEFEGJCJOO")]
    public Text PLEFEGJCJOO { get; set; }

    [JsonPropertyName("descParamList")]
    [DataArray(Length = 3)]
    public IList<IList<double>> DescParamList { get; set; } = default!;

    [JsonPropertyName("PBLMHJIPEHN")]
    [DataArray(Length = 3)]
    public IList<bool> PBLMHJIPEHN { get; set; } = default!;

    [JsonPropertyName("JNFDJJCLCBA")]
    public string? JNFDJJCLCBA { get; set; }

    [JsonPropertyName("GMHNKGFHLMC")]
    public string? GMHNKGFHLMC { get; set; }

    [JsonPropertyName("ADCOECLELMG")]
    public double ADCOECLELMG { get; set; }

    [JsonPropertyName("costPoints")]
    public int CostPoints { get; set; }

    [JsonPropertyName("cardType")]
    public string? CardType { get; set; }

    [JsonPropertyName("EMOKONNNHCA")]
    public int EMOKONNNHCA { get; set; }

    [JsonPropertyName("NFOAKLIOPMH")]
    public TargetTypeEffectParam3 NFOAKLIOPMH { get; set; } = default!;

    [JsonPropertyName("CIPIIHPDONO")]
    public int CIPIIHPDONO { get; set; }

    [JsonPropertyName("JODJCIKEGHK")]
    public bool JODJCIKEGHK { get; set; }

    [JsonPropertyName("NJANICODPCH")]
    public bool NJANICODPCH { get; set; }

    [JsonPropertyName("PLDAMHDHOLO")]
    public IList<ChessEffectParam> PLDAMHDHOLO { get; set; } = default!;

    [JsonPropertyName("KEIHCOBHONL")]
    public bool? KEIHCOBHONL { get; set; }

    [JsonPropertyName("OPPLAFJOCAM")]
    public string? OPPLAFJOCAM { get; set; }
}
