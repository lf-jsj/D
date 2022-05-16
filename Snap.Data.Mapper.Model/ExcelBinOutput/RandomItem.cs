namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class RandomItem : DataObject
{
    [JsonPropertyName("count")]
    public int Count { get; set; }
}
