namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeOfferingDataExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("NAJHKCJFHGG")]
    public Text NAJHKCJFHGG { get; set; }

    [JsonPropertyName("PICBICJHIEI")]
    public IList<string> PICBICJHIEI { get; set; } = default!;

    [JsonPropertyName("ALBOKKCLKNA")]
    public Text ALBOKKCLKNA { get; set; }

    [JsonPropertyName("EHKDHPNNJDB")]
    public IList<string> EHKDHPNNJDB { get; set; } = default!;

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}