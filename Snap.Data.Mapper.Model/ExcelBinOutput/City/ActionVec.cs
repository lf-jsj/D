namespace Snap.Data.Mapper.Model.ExcelBinOutput.City;

public class ActionVec : DataObject
{
    [JsonPropertyName("param1Vec")]
    public IList<int> Param1Vec { get; set; } = default!;

    [JsonPropertyName("param2Vec")]
    public IList<int> Param2Vec { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}

