namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class Schedule : DataObject
{
    [JsonPropertyName("floorList")]
    public IList<int> FloorList { get; set; } = default!;

    [JsonPropertyName("openTime")]
    public string OpenTime { get; set; } = default!;
}
