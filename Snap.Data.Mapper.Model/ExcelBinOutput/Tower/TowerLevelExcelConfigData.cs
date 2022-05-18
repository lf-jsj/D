namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class TowerLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("levelGroupId")]
    public int LevelGroupId { get; set; }

    [JsonPropertyName("levelIndex")]
    public int LevelIndex { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("conds")]
    public IList<Cond> Conds { get; set; } = default!;

    [JsonPropertyName("towerBuffConfigStrList")]
    public IList<string> TowerBuffConfigStrList { get; set; } = default!;

    [JsonPropertyName("firstPassRewardId")]
    public int FirstPassRewardId { get; set; }

    [JsonPropertyName("monsterLevel")]
    public int MonsterLevel { get; set; }

    [JsonPropertyName("firstMonsterList")]
    public IList<int> FirstMonsterList { get; set; } = default!;

    [JsonPropertyName("secondMonsterList")]
    public IList<int> SecondMonsterList { get; set; } = default!;
}