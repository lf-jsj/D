namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salvage;

public class SalvageTypeDataExcelConfigData : DataObject
{
    [JsonPropertyName("playType")]
    public string PlayType { get; set; } = default!;
}