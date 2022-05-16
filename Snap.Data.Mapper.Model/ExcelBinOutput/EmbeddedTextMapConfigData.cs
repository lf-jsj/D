namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class EmbeddedTextMapConfigData : DataObject
{
    [JsonPropertyName("textMapId")]
    public string TextMapId { get; set; } = default!;

    [JsonPropertyName("textMapContentTextMapHash")]
    public Text TextMapContentTextMapHash { get; set; }
}
