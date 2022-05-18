namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ManualTextMapConfigData : DataObject
{
    [JsonPropertyName("textMapId")]
    public string TextMapId { get; set; } = default!;

    [JsonPropertyName("textMapContentTextMapHash")]
    public Text TextMapContentTextMapHash { get; set; }

    [JsonPropertyName("paramTypes")]
    public IList<string> ParamTypes { get; set; } = default!;
}