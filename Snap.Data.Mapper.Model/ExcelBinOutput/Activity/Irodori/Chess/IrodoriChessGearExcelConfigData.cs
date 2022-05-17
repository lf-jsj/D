namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Chess;

public class IrodoriChessGearExcelConfigData : DataObject
{
    [JsonPropertyName("BPEMACJMEFC")]
    public int BPEMACJMEFC { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("DJIGCOELMCK")]
    public int DJIGCOELMCK { get; set; }

    [JsonPropertyName("gearNameTextMapHash")]
    public Text GearNameTextMapHash { get; set; }

    [JsonPropertyName("gearShortNameTextMapHash")]
    public Text GearShortNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("gearIconPath")]
    public string GearIconPath { get; set; } = default!;

    [JsonPropertyName("GCHFGPIHLEP")]
    public string GCHFGPIHLEP { get; set; } = default!;

    [JsonPropertyName("mapIconPath")]
    public string MapIconPath { get; set; } = default!;

    [JsonPropertyName("attack")]
    public int Attack { get; set; }

    [JsonPropertyName("attackSpeed")]
    public int AttackSpeed { get; set; }

    [JsonPropertyName("attackRange")]
    public int AttackRange { get; set; }

    [JsonPropertyName("isEnableRotate")]
    public bool? IsEnableRotate { get; set; }

    [JsonPropertyName("NADOHIECJML")]
    public int? NADOHIECJML { get; set; }
}
public class IrodoriChessMapExcelConfigData : DataObject
{
    [JsonPropertyName("IDAMAAKDGEH")]
    public int IDAMAAKDGEH { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("PAMPLCLLMIH")]
    public int PAMPLCLLMIH { get; set; }

    [JsonPropertyName("show")]
    public bool Show { get; set; }

    [JsonPropertyName("LGGJBJAAPBL")]
    public IList<int> LGGJBJAAPBL { get; set; } = default!;

    [JsonPropertyName("JCBILEGNCLF")]
    public int JCBILEGNCLF { get; set; }

    [JsonPropertyName("PGFLEPHDECA")]
    public IDictionary<string,int> PGFLEPHDECA { get; set; } = default!;

    [JsonPropertyName("DHIMKKNHGML")]
    public IList<int> DHIMKKNHGML { get; set; } = default!;

    [JsonPropertyName("NLONHMCJLOF")]
    public IList<int> NLONHMCJLOF { get; set; } = default!;

    [JsonPropertyName("KGKFPEHMECE")]
    public IList<int> KGKFPEHMECE { get; set; } = default!;

    [JsonPropertyName("HODLDCOCPHB")]
    public IList<int> HODLDCOCPHB { get; set; } = default!;

    [JsonPropertyName("PLILKNDBGDI")]
    public int PLILKNDBGDI { get; set; }

    [JsonPropertyName("mapNameTextMapHash")]
    public Text MapNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("mapIconPath")]
    public string MapIconPath { get; set; } = default!;

    [JsonPropertyName("ENBFNEOMMDJ")]
    public IDictionary<string, int> ENBFNEOMMDJ { get; set; } = default!;

    [JsonPropertyName("BJGLPOFKJBE")]
    public int? BJGLPOFKJBE { get; set; }
}
