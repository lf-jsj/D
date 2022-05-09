namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class ActivityChessScheduleExcelConfigData : DataObject
{
    [JsonPropertyName("ICDBBIIDNHC")]
    public int ICDBBIIDNHC { get; set; }

    [JsonPropertyName("OBBDOBMFLJK")]
    public int OBBDOBMFLJK { get; set; }

    [JsonPropertyName("openMapList")]
    public IList<int> OpenMapList { get; set; } = default!;
}