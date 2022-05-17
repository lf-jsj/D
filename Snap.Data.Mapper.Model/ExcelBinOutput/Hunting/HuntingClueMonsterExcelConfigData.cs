namespace Snap.Data.Mapper.Model.ExcelBinOutput.Hunting;

public class HuntingClueMonsterExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("monsterId")]
    public int MonsterId { get; set; }

    [JsonPropertyName("reviseLevelId")]
    public int ReviseLevelId { get; set; }

    [JsonPropertyName("groupType")]
    public string GroupType { get; set; } = default!;

    [JsonPropertyName("monsterGroupId")]
    public int MonsterGroupId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("isClueMonster")]
    public bool? IsClueMonster { get; set; }
}
