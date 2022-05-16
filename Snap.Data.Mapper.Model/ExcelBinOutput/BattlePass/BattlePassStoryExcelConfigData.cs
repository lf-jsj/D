namespace Snap.Data.Mapper.Model.ExcelBinOutput.BattlePass;

public class BattlePassStoryExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("storyUnlockLevel")]
    public IList<int> StoryUnlockLevel { get; set; } = default!;

    [JsonPropertyName("storyId")]
    public IList<int> StoryId { get; set; } = default!;

    [JsonPropertyName("storyTitle")]
    public IList<Text> StoryTitle { get; set; } = default!;
}