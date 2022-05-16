namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.DragonSpine;

public class DragonSpineMissionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("watcherId")]
    public int WatcherId { get; set; }

    [JsonPropertyName("finishExec")]
    public IList<FinishExec> FinishExec { get; set; } = default!;
}
