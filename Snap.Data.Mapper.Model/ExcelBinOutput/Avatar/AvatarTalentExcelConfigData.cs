using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarTalentExcelConfigData : DataObject
{
    [JsonPropertyName("talentId")]
    public int TalentId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("mainCostItemId")]
    public int MainCostItemId { get; set; }

    [JsonPropertyName("mainCostItemCount")]
    public int MainCostItemCount { get; set; }

    [JsonPropertyName("openConfig")]
    public string OpenConfig { get; set; } = default!;

    [JsonPropertyName("addProps")]
    public IList<PropTypeValue> AddProps { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<float> ParamList { get; set; } = default!;

    [JsonPropertyName("prevTalent")]
    public int? PrevTalent { get; set; }
}
