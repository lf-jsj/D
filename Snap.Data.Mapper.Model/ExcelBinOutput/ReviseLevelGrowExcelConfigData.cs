namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ReviseLevelGrowExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("grade")]
    public IList<int> Grade { get; set; } = default!;
}