namespace Snap.Data.Mapper.Model.ExcelBinOutput.Hunting;

public class HuntingMonsterExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("monsterId")]
    public int MonsterId { get; set; }

    [JsonPropertyName("affix")]
    public IList<int> Affix { get; set; } = default!;

    [JsonPropertyName("abilityGroup")]
    public string AbilityGroup { get; set; } = default!;

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("reviseLevelId")]
    public int ReviseLevelId { get; set; }

    [JsonPropertyName("cityList")]
    public IList<int> CityList { get; set; } = default!;

    [JsonPropertyName("limitTime")]
    public int LimitTime { get; set; }

    [JsonPropertyName("searchPointNum")]
    public int SearchPointNum { get; set; }

    [JsonPropertyName("PEEONIFFBGG")]
    public IList<DataObject> PEEONIFFBGG { get; set; } = default!;

    [JsonPropertyName("clueTextIdList")]
    public IList<int> ClueTextIdList { get; set; } = default!;

    [JsonPropertyName("newsTextTextMapHash")]
    public Text NewsTextTextMapHash { get; set; }

    [JsonPropertyName("traitTextTextMapHash")]
    public Text TraitTextTextMapHash { get; set; }

    [JsonPropertyName("DIECMFFCFMA")]
    public Text DIECMFFCFMA { get; set; }

    [JsonPropertyName("FPFMIBADCLJ")]
    public Text FPFMIBADCLJ { get; set; }

    [JsonPropertyName("FBDGNCAKHEI")]
    public Text FBDGNCAKHEI { get; set; }

    [JsonPropertyName("AIHBFPMHOED")]
    public Text AIHBFPMHOED { get; set; }

    [JsonPropertyName("refreshCond")]
    public IList<int> RefreshCond { get; set; } = default!;

    [JsonPropertyName("createPosType")]
    public string CreatePosType { get; set; } = default!;

    [JsonPropertyName("IGJNOMBHLOP")]
    public bool? IGJNOMBHLOP { get; set; }

    [JsonPropertyName("OKNOHAGKLLC")]
    public int? OKNOHAGKLLC { get; set; }

    [JsonPropertyName("difficulty")]
    public string Difficulty { get; set; } = default!;

    [JsonPropertyName("initialPose")]
    public int? InitialPose { get; set; }
}