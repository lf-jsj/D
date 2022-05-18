namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class Cond : DataObject
{
    [JsonPropertyName("towerCondType")]
    public string TowerCondType { get; set; } = default!;

    [JsonPropertyName("PFDMBMCLFHG")]
    public IList<int> PFDMBMCLFHG { get; set; } = default!;

    [JsonPropertyName("argumentList")]
    public IList<int> ArgumentList { get; set; } = default!;
}
