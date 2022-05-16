namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class BlossomReviseExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("grade")]
    public IList<int> Grade { get; set; } = default!;
}