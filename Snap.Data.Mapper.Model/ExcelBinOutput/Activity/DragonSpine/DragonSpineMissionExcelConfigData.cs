namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.DragonSpine;
using Snap.Data.Mapper.Model.Common.Param;

public class DragonSpineMissionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("watcherId")]
    public int WatcherId { get; set; }

    [JsonPropertyName("finishExec")]
    public IList<TypeParam<string>> FinishExec { get; set; } = default!;
}
