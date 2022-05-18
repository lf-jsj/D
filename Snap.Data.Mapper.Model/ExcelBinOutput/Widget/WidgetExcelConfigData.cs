namespace Snap.Data.Mapper.Model.ExcelBinOutput.Widget;

public class WidgetExcelConfigData : DataObject
{
    [JsonPropertyName("materialID")]
    public int MaterialID { get; set; }

    [JsonPropertyName("customizeDesc")]
    public IList<Text> CustomizeDesc { get; set; } = default!;

    [JsonPropertyName("jsonAddr")]
    public bool? JsonAddr { get; set; }

    [JsonPropertyName("pushTipsId")]
    public int? PushTipsId { get; set; }
}