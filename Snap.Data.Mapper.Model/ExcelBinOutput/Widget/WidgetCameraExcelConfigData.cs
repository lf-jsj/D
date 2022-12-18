namespace Snap.Data.Mapper.Model.ExcelBinOutput.Widget;

public class WidgetCameraExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("OGIIFCLAIPP")]
    public float OGIIFCLAIPP { get; set; }

    [JsonPropertyName("OBLIIPHKPGE")]
    public string OBLIIPHKPGE { get; set; } = default!;

    [JsonPropertyName("NJGKLPKKDOC")]
    public Text NJGKLPKKDOC { get; set; }

    [JsonPropertyName("PBLCNBPFGLG")]
    public Text PBLCNBPFGLG { get; set; }

    [JsonPropertyName("PAFLEDKDGGA")]
    public Text PAFLEDKDGGA { get; set; }
}