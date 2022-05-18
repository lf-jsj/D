namespace Snap.Data.Mapper.Model.ExcelBinOutput.PushTip;
public class PushTipsCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("PushTipId")]
    public int PushTipId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }
}
