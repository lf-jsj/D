namespace Snap.Data.Mapper.Model.ExcelBinOutput.Daily;
public class DailyDungeonConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("monday")]
    public IList<int> Monday { get; set; } = default!;

    [JsonPropertyName("tuesday")]
    public IList<int> Tuesday { get; set; } = default!;

    [JsonPropertyName("wednesday")]
    public IList<int> Wednesday { get; set; } = default!;

    [JsonPropertyName("thursday")]
    public IList<int> Thursday { get; set; } = default!;

    [JsonPropertyName("friday")]
    public IList<int> Friday { get; set; } = default!;

    [JsonPropertyName("saturday")]
    public IList<int> Saturday { get; set; } = default!;

    [JsonPropertyName("sunday")]
    public IList<int> Sunday { get; set; } = default!;
}
