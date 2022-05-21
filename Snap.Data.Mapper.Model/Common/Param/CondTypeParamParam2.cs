namespace Snap.Data.Mapper.Model.Common.Param;

public class CondTypeParamParam2 : DataObject
{
    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;

    [JsonPropertyName("param")]
    public int? Param { get; set; }

    [JsonPropertyName("param2")]
    public int? Param2 { get; set; }
}
