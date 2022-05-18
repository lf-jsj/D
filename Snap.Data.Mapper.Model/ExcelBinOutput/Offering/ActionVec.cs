namespace Snap.Data.Mapper.Model.ExcelBinOutput.Offering;

public class ActionVec : DataObject
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }
}
