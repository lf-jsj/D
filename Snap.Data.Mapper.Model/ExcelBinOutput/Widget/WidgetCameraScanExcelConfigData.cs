namespace Snap.Data.Mapper.Model.ExcelBinOutput.Widget;

public class WidgetCameraScanExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cameraID")]
    public int CameraID { get; set; }

    [JsonPropertyName("configID")]
    public int ConfigID { get; set; }

    [JsonPropertyName("JLLOINIHGHC")]
    public IList<int> JLLOINIHGHC { get; set; } = default!;

    [JsonPropertyName("MMOCBMLFKME")]
    public bool MMOCBMLFKME { get; set; }

    [JsonPropertyName("AJGFOIFJEIG")]
    public string AJGFOIFJEIG { get; set; } = default!;
}
