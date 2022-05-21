using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ProudSkillExcelConfigData : DataObject
{
    [JsonPropertyName("proudSkillId")]
    public int ProudSkillId { get; set; }

    [JsonPropertyName("proudSkillGroupId")]
    public int ProudSkillGroupId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("proudSkillType")]
    public int ProudSkillType { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("unlockDescTextMapHash")]
    public Text UnlockDescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("costItems")]
    public IList<IdCount<int>> CostItems { get; set; } = default!;

    [JsonPropertyName("filterConds")]
    public IList<string> FilterConds { get; set; } = default!;

    [JsonPropertyName("breakLevel")]
    public int BreakLevel { get; set; }

    [JsonPropertyName("paramDescList")]
    public IList<Text> ParamDescList { get; set; } = default!;

    [JsonPropertyName("lifeEffectParams")]
    public IList<string> LifeEffectParams { get; set; } = default!;

    [JsonPropertyName("openConfig")]
    public string OpenConfig { get; set; } = default!;

    [JsonPropertyName("addProps")]
    public IList<PropTypeValue> AddProps { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<double> ParamList { get; set; } = default!;

    [JsonPropertyName("lifeEffectType")]
    public string LifeEffectType { get; set; } = default!;

    [JsonPropertyName("coinCost")]
    public int? CoinCost { get; set; }

    [JsonPropertyName("effectiveForTeam")]
    public int? EffectiveForTeam { get; set; }

    [JsonPropertyName("OABABENBOMP")]
    public bool? OABABENBOMP { get; set; }
}
