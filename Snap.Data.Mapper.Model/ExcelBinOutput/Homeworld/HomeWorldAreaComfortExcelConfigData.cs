namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldAreaComfortExcelConfigData : DataObject
{
    [JsonPropertyName("configID")]
    public int ConfigID { get; set; }

    [JsonPropertyName("sceneID")]
    public int SceneID { get; set; }

    [JsonPropertyName("areaID")]
    public int AreaID { get; set; }

    [JsonPropertyName("areaType")]
    public string AreaType { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("maxComfort")]
    public int MaxComfort { get; set; }

    [JsonPropertyName("JBEBBNLNDAL")]
    public string JBEBBNLNDAL { get; set; } = default!;

    [JsonPropertyName("PBAGJEBAONG")]
    public int PBAGJEBAONG { get; set; }

    [JsonPropertyName("BPFBBEPMIHM")]
    public int BPFBBEPMIHM { get; set; }

    [JsonPropertyName("DKGCOJBLCJM")]
    public int DKGCOJBLCJM { get; set; }

    [JsonPropertyName("LLKGIIKBOFE")]
    public IList<double> LLKGIIKBOFE { get; set; } = default!;

    [JsonPropertyName("BHMHDPGKNHA")]
    public IList<double> BHMHDPGKNHA { get; set; } = default!;
}
