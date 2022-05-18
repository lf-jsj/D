namespace Snap.Data.Mapper.Model.ExcelBinOutput.Material;

public class ItemUse : DataObject
{
    [JsonPropertyName("useParam")]
    public IList<string> UseParam { get; set; } = default!;

    [JsonPropertyName("useOp")]
    public string UseOp { get; set; } = default!;
}
