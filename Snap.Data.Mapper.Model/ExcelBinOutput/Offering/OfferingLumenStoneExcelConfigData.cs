namespace Snap.Data.Mapper.Model.ExcelBinOutput.Offering;

public class OfferingLumenStoneExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("MEGJPJGKHKO")]
    public Text MEGJPJGKHKO { get; set; }

    [JsonPropertyName("BKNKFEABMHN")]
    public Text BKNKFEABMHN { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}