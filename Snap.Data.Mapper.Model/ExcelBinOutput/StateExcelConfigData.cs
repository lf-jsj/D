namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class StateExcelConfigData : DataObject
{
    [JsonPropertyName("stateName")]
    public string StateName { get; set; } = default!;

    [JsonPropertyName("stateType")]
    public string StateType { get; set; } = default!;

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }
}