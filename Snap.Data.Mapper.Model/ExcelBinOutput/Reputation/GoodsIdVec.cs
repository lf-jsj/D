namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;

public class GoodsIdVec : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param1")]
    public int Param1 { get; set; }
}
