namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class Param2CondType : DataObject
{
    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;

    [JsonPropertyName("param")]
    public int? Param { get; set; }

    [JsonPropertyName("param2")]
    public int? Param2 { get; set; }
}
