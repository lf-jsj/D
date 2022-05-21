using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class EquipAffixExcelConfigData : DataObject
{
    [JsonPropertyName("affixId")]
    public int AffixId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("openConfig")]
    public string OpenConfig { get; set; } = default!;

    [JsonPropertyName("addProps")]
    public IList<PropTypeValue> AddProps { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<double> ParamList { get; set; } = default!;

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}