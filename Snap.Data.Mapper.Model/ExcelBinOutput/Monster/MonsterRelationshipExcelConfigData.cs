namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterRelationshipExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("tagStr")]
    public string TagStr { get; set; } = default!;

    [JsonPropertyName("monsterRarity")]
    public string MonsterRarity { get; set; } = default!;
}