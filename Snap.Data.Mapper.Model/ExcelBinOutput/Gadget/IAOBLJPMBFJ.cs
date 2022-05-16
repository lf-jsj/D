namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class IAOBLJPMBFJ : DataObject
{
    [JsonPropertyName("actionType")]
    public string ActionType { get; set; } = default!;

    [JsonPropertyName("param")]
    public IList<int> Param { get; set; } = default!;
}
