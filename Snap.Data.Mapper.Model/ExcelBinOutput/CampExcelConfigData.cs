namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class CampExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("trophicLevel")]
    public int TrophicLevel { get; set; }

    [JsonPropertyName("enemyCampList")]
    public IList<int> EnemyCampList { get; set; } = default!;
}