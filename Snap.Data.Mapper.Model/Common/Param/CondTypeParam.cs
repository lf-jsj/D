namespace Snap.Data.Mapper.Model.Common.Param;

public class CondTypeParam : DataObject
{
    [JsonPropertyName("param")]
    public IList<string> Param { get; set; } = default!;

    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;
}