namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabLoopDungeonDifficultyExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("difficulty")]
    public string Difficulty { get; set; } = default!;

    [JsonPropertyName("scoreRatio")]
    public float ScoreRatio { get; set; }

    [JsonPropertyName("baseScore")]
    public int BaseScore { get; set; }
}
