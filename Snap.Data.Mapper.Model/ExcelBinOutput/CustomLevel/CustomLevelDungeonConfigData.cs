namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomLevel;

public class CustomLevelDungeonConfigData : DataObject
{
    [JsonPropertyName("dungeonID")]
    public int DungeonID { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("jsonPath")]
    public string JsonPath { get; set; } = default!;

    [JsonPropertyName("MFOOKLAHEPC")]
    public string MFOOKLAHEPC { get; set; } = default!;

    [JsonPropertyName("GDCCONDAFOC")]
    public Text GDCCONDAFOC { get; set; }

    [JsonPropertyName("MMGNNEIDDAH")]
    public int MMGNNEIDDAH { get; set; }

    [JsonPropertyName("KHKFGAINCLM")]
    public HashSuffix KHKFGAINCLM { get; set; }

    [JsonPropertyName("PKNPFEGINNH")]
    public HashPre PKNPFEGINNH { get; set; }

    [JsonPropertyName("PPDCNPCCMCP")]
    public int PPDCNPCCMCP { get; set; }

    [JsonPropertyName("OCHBFMMDENB")]
    public Text OCHBFMMDENB { get; set; }

    [JsonPropertyName("FILEIEFPCPM")]
    public string FILEIEFPCPM { get; set; } = default!;

    [JsonPropertyName("IEMMJOFKEKA")]
    public IList<int> IEMMJOFKEKA { get; set; } = default!;
}
