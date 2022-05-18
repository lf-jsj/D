namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterMultiPlayerExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("PropPer")]
    public IList<PropPer> PropPer { get; set; } = default!;

    [JsonPropertyName("EndureNum")]
    public IList<int> EndureNum { get; set; } = default!;

    [JsonPropertyName("ElementShield")]
    public IList<double> ElementShield { get; set; } = default!;
}