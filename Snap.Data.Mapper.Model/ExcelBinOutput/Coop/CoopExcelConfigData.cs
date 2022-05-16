namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;

public class CoopExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("CoopCfg")]
    public string CoopCfg { get; set; } = default!;
}
