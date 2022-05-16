namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ConstValueExcelConfigData : DataObject
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("value")]
    public IList<string> Value { get; set; } = default!;
}
