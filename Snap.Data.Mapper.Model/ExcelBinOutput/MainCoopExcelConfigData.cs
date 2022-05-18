namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class MainCoopExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("mainCoopCfg")]
    public string MainCoopCfg { get; set; } = default!;

    [JsonPropertyName("mainQuestSeries")]
    public int MainQuestSeries { get; set; }
}
