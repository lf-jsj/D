namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonElementChallengeExcelConfigData : DataObject
{
    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("trialAvatarId")]
    public IList<int> TrialAvatarId { get; set; } = default!;

    [JsonPropertyName("tutorialId")]
    public int TutorialId { get; set; }
}