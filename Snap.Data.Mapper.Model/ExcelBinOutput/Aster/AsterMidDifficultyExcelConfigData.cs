namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;

public class AsterMidDifficultyExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("worldLevelVec")]
    public IList<int> WorldLevelVec { get; set; } = default!;

    [JsonPropertyName("dropId")]
    public int DropId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("resin")]
    public int Resin { get; set; }

    [JsonPropertyName("recommendLevel")]
    public int RecommendLevel { get; set; }

    [JsonPropertyName("monsterLevel")]
    public int MonsterLevel { get; set; }
}
