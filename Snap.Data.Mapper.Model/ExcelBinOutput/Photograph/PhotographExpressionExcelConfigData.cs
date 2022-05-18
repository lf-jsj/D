namespace Snap.Data.Mapper.Model.ExcelBinOutput.Photograph;

public class PhotographExpressionExcelConfigData : DataObject
{
    [JsonPropertyName("emotionName")]
    public string EmotionName { get; set; } = default!;

    [JsonPropertyName("phonemeName")]
    public string PhonemeName { get; set; } = default!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("emotionDescriptionTextMapHash")]
    public Text EmotionDescriptionTextMapHash { get; set; }

    [JsonPropertyName("unlockDescTextMapHash")]
    public Text UnlockDescTextMapHash { get; set; }

    [JsonPropertyName("fetterId")]
    public int FetterId { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("openConds")]
    public IList<OpenCond> OpenConds { get; set; } = default!;

    [JsonPropertyName("finishConds")]
    public IList<DataObject> FinishConds { get; set; } = default!;
}