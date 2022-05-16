namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class DieTypeTipsExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dieType")]
    public string DieType { get; set; } = default!;

    [JsonPropertyName("tips")]
    public IList<Text> Tips { get; set; } = default!;

    [JsonPropertyName("monsterID")]
    public int? MonsterID { get; set; }
}
