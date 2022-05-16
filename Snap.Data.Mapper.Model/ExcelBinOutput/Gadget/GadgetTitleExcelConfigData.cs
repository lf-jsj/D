namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class GadgetTitleExcelConfigData : DataObject
{
    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }
}