namespace Snap.Data.Mapper.Model.Common;

public class PoolIdName : DataObject
{
    [JsonPropertyName("name")]
    public IList<string> Name { get; set; } = default!;

    [JsonPropertyName("poolId")]
    public int PoolId { get; set; }
}
