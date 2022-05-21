namespace Snap.Data.Mapper.Model.ExcelBinOutput.QTE;

public class QTEStepExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("GGCFCFONPDJ")]
    public string GGCFCFONPDJ { get; set; } = default!;
}