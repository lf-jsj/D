namespace Snap.Data.Mapper.Model.ExcelBinOutput.Routine;

public class FinishContent : DataObject
{
    [JsonPropertyName("finishType")]
    public string FinishType { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }
}
