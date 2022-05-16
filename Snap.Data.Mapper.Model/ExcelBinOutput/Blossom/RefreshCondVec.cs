namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class RefreshCondVec : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<int> Param { get; set; } = default!;
}
