namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ShareCDExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("DOFOGJCEFBB")]
    public IList<DOFOGJCEFBB> DOFOGJCEFBB { get; set; } = default!;
}
