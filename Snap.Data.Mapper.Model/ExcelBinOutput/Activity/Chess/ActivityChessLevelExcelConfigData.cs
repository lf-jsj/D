namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class ActivityChessLevelExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("MOLEHINJAPP")]
    public int MOLEHINJAPP { get; set; }

    [JsonPropertyName("GDCEIBPJHLL")]
    public int GDCEIBPJHLL { get; set; }

    [JsonPropertyName("AFFDNGAJAKD")]
    public int AFFDNGAJAKD { get; set; }

    [JsonPropertyName("EMOKONNNHCA")]
    public int EMOKONNNHCA { get; set; }

    [JsonPropertyName("GEKAFIPCIKC")]
    public int GEKAFIPCIKC { get; set; }

    [JsonPropertyName("GFJPKOKCCOH")]
    public IList<int> GFJPKOKCCOH { get; set; } = default!;

    [JsonPropertyName("NIMKPAEANCO")]
    public int NIMKPAEANCO { get; set; }

    [JsonPropertyName("PBJNFJMINPJ")]
    public bool PBJNFJMINPJ { get; set; }

    [JsonPropertyName("KGFDFCPCHPI")]
    public bool KGFDFCPCHPI { get; set; }

    [JsonPropertyName("DECBLNAJEOP")]
    public string? DECBLNAJEOP { get; set; }
}
