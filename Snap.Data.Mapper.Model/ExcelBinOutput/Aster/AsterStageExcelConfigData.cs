namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;

public class AsterStageExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("stageNameTextMapHash")]
    public Text StageNameTextMapHash { get; set; }

    [JsonPropertyName("openday")]
    public int Openday { get; set; }

    [JsonPropertyName("openQuestId")]
    public int OpenQuestId { get; set; }

    [JsonPropertyName("introTextMapHash")]
    public Text IntroTextMapHash { get; set; }

    [JsonPropertyName("storyTextMapHash")]
    public Text StoryTextMapHash { get; set; }

    [JsonPropertyName("questIdList")]
    public IList<int> QuestIdList { get; set; } = default!;

    [JsonPropertyName("unlockScore")]
    public int? UnlockScore { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int? RewardPreviewId { get; set; }
}