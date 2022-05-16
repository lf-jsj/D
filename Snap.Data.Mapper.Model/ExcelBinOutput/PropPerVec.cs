namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class PropPerVec : DataObject
{
    [JsonPropertyName("propType")]
    public string PropType { get; set; } = default!;

    [JsonPropertyName("propValueVec")]
    public IList<double> PropValueVec { get; set; } = default!;
}
