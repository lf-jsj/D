namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class PropPer : DataObject
{
    [JsonPropertyName("PropType")]
    public string PropType { get; set; } = default!;

    [JsonPropertyName("PropValue")]
    public IList<double> PropValue { get; set; } = default!;
}
