namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RogueStageExcelConfigData : DataObject
{
    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("firstPassRewardId")]
    public int FirstPassRewardId { get; set; }

    [JsonPropertyName("CLJHOMBDOOE")]
    public int CLJHOMBDOOE { get; set; }

    [JsonPropertyName("EAJLJOIBKDK")]
    public int EAJLJOIBKDK { get; set; }

    [JsonPropertyName("LLCBJLLIMKP")]
    public int LLCBJLLIMKP { get; set; }

    [JsonPropertyName("maxLevel")]
    public int MaxLevel { get; set; }

    [JsonPropertyName("reviseLevelId")]
    public int ReviseLevelId { get; set; }

    [JsonPropertyName("stageNameTextMapHash")]
    public Text StageNameTextMapHash { get; set; }

    [JsonPropertyName("NBONENPBDBM")]
    public Text NBONENPBDBM { get; set; }

    [JsonPropertyName("HIKFPLMEALE")]
    public IList<int> HIKFPLMEALE { get; set; } = default!;

    [JsonPropertyName("monsterIdList")]
    public IList<IList<int>> MonsterIdList { get; set; } = default!;

    [JsonPropertyName("DMAOEHKCLGF")]
    public IList<IList<int>> DMAOEHKCLGF { get; set; } = default!;

    [JsonPropertyName("preQuestId")]
    public int PreQuestId { get; set; }

    [JsonPropertyName("HCDHPKKNOBF")]
    public int HCDHPKKNOBF { get; set; }

    [JsonPropertyName("LMJIGGHFAEH")]
    public IList<DataObject> LMJIGGHFAEH { get; set; } = default!;

    [JsonPropertyName("CDPANKMHEGH")]
    public bool CDPANKMHEGH { get; set; }
}