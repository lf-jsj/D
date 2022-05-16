namespace Snap.Data.Mapper.Model.ExcelBinOutput.Buff;

public class BuffIconExcelConfigData : DataObject
{
    [JsonPropertyName("buffID")]
    public int BuffID { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("mutexType")]
    public int MutexType { get; set; }
}