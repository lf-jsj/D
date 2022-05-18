namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class ElemList : DataObject
{
    [JsonPropertyName("name")]
    public IList<string> Name { get; set; } = default!;

    [JsonPropertyName("poolId")]
    public int PoolId { get; set; }
}
