namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Effigy;

public class EffigyDifficultyExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("challengeId")]
    public int ChallengeId { get; set; }

    [JsonPropertyName("baseScore")]
    public int BaseScore { get; set; }

    [JsonPropertyName("monsterDifficulty")]
    public string MonsterDifficulty { get; set; } = default!;
    
    [JsonPropertyName("monsterLevel")]
    public int MonsterLevel { get; set; }

    [JsonPropertyName("scoreRatio")]
    public float ScoreRatio { get; set; }

    [JsonPropertyName("KFAPPIPPEOO")]
    public int KFAPPIPPEOO { get; set; }
}
