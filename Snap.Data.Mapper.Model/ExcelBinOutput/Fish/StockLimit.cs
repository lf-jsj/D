namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;

public class StockLimit : DataObject
{
    [JsonPropertyName("OKJLOCEIHNL")]
    public string OKJLOCEIHNL { get; set; } = default!;

    [JsonPropertyName("CHIMDAJADJB")]
    public int CHIMDAJADJB { get; set; }

    [JsonPropertyName("MKOADGMNGJC")]
    public int MKOADGMNGJC { get; set; }
}
