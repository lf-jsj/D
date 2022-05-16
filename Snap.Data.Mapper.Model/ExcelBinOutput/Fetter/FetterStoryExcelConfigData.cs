namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class FetterStoryExcelConfigData : DataObject
{
    [JsonPropertyName("storyTitleTextMapHash")]
    public Text StoryTitleTextMapHash { get; set; }

    [JsonPropertyName("storyContextTextMapHash")]
    public Text StoryContextTextMapHash { get; set; }

    [JsonPropertyName("storyTitle2TextMapHash")]
    public Text StoryTitle2TextMapHash { get; set; }

    [JsonPropertyName("storyContext2TextMapHash")]
    public Text StoryContext2TextMapHash { get; set; }

    [JsonPropertyName("tips")]
    public IList<Text> Tips { get; set; } = default!;

    [JsonPropertyName("storyTitleLockedTextMapHash")]
    public Text StoryTitleLockedTextMapHash { get; set; }

    [JsonPropertyName("fetterId")]
    public int FetterId { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("openConds")]
    public IList<ParamListCondType> OpenConds { get; set; } = default!;

    [JsonPropertyName("finishConds")]
    public IList<ParamListCondType> FinishConds { get; set; } = default!;
}