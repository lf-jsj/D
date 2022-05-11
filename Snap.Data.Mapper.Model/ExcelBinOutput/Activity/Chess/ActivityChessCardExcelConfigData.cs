namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class NFOAKLIOPMH : DataObject
{
    [JsonPropertyName("targetType")]
    public string TargetType { get; set; } = default!;

    [JsonPropertyName("targetParamList")]
    public IList<int> TargetParamList { get; set; } = default!;

    [JsonPropertyName("effectType")]
    public string EffectType { get; set; } = default!;

    [JsonPropertyName("effectStrParam")]
    public string EffectStrParam { get; set; } = default!;

    [JsonPropertyName("effectParam1")]
    public int EffectParam1 { get; set; }

    [JsonPropertyName("DDLBNPOIENG")]
    public int? DDLBNPOIENG { get; set; }

    [JsonPropertyName("effectParam2")]
    public int? EffectParam2 { get; set; }

    [JsonPropertyName("effectParam3")]
    public int? EffectParam3 { get; set; }

    [JsonPropertyName("FPABBMBGIFH")]
    public int? FPABBMBGIFH { get; set; }
}

public class PLDAMHDHOLO : DataObject
{
    [JsonPropertyName("targetParamList")]
    public IList<object> TargetParamList { get; set; } = default!;

    [JsonPropertyName("effectStrParam")]
    public string EffectStrParam { get; set; } = default!;

    [JsonPropertyName("effectType")]
    public string EffectType { get; set; } = default!;

    [JsonPropertyName("effectParam1")]
    public int? EffectParam1 { get; set; }

    [JsonPropertyName("effectParam2")]
    public int? EffectParam2 { get; set; }

    [JsonPropertyName("FPABBMBGIFH")]
    public int? FPABBMBGIFH { get; set; }

    [JsonPropertyName("DDLBNPOIENG")]
    public int? DDLBNPOIENG { get; set; }
}

public class ActivityChessCardExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("PMIHFKKMOML")]
    public int PMIHFKKMOML { get; set; }

    [JsonPropertyName("IOHHOMNCMBJ")]
    public string IOHHOMNCMBJ { get; set; } = default!;

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
    public string JNFDJJCLCBA { get; set; } = default!;

    [JsonPropertyName("GMHNKGFHLMC")]
    public string GMHNKGFHLMC { get; set; } = default!;

    [JsonPropertyName("ADCOECLELMG")]
    public double ADCOECLELMG { get; set; }

    [JsonPropertyName("costPoints")]
    public int CostPoints { get; set; }

    [JsonPropertyName("cardType")]
    public string CardType { get; set; } = default!;

    [JsonPropertyName("EMOKONNNHCA")]
    public int EMOKONNNHCA { get; set; }

    [JsonPropertyName("NFOAKLIOPMH")]
    public NFOAKLIOPMH NFOAKLIOPMH { get; set; } = default!;

    [JsonPropertyName("CIPIIHPDONO")]
    public int CIPIIHPDONO { get; set; }

    [JsonPropertyName("JODJCIKEGHK")]
    public bool JODJCIKEGHK { get; set; }

    [JsonPropertyName("NJANICODPCH")]
    public bool NJANICODPCH { get; set; }

    [JsonPropertyName("PLDAMHDHOLO")]
    public IList<PLDAMHDHOLO> PLDAMHDHOLO { get; set; } = default!;

    [JsonPropertyName("KEIHCOBHONL")]
    public bool? KEIHCOBHONL { get; set; }

    [JsonPropertyName("OPPLAFJOCAM")]
    public string OPPLAFJOCAM { get; set; } = default!;
}
