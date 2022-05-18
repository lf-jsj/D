namespace Snap.Data.Mapper.Model.ExcelBinOutput.Widget;
public class WidgetActiveExcelConfigData : DataObject
{
    [JsonPropertyName("materialID")]
    public int MaterialID { get; set; }

    [JsonPropertyName("IDEPJECLEAC")]
    public IList<DataObject> IDEPJECLEAC { get; set; } = default!;

    [JsonPropertyName("PCGAGHBLEEF")]
    public string PCGAGHBLEEF { get; set; } = default!;

    [JsonPropertyName("JLJBMIFBGKK")]
    public IList<int> JLJBMIFBGKK { get; set; } = default!;

    [JsonPropertyName("NNMLBKNFGCD")]
    public bool? NNMLBKNFGCD { get; set; }
}