namespace Snap.Data.Mapper.Model.ExcelBinOutput.Offering;

public class FJFOAPDLHDF : DataObject
{
    [JsonPropertyName("param")]
    public string Param { get; set; } = default!;

    [JsonPropertyName("actionType")]
    public string ActionType { get; set; } = default!;
}
