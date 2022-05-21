namespace Snap.Data.Mapper.Model.Common.Wrapper;

public class CountWrapper : DataObject
{
    [JsonPropertyName("count")]
    public int Count { get; set; }
}
