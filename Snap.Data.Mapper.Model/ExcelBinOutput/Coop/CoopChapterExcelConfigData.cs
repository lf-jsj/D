namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;

public class CoopChapterExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("chapterNameTextMapHash")]
    public Text ChapterNameTextMapHash { get; set; }

    [JsonPropertyName("coopPageTitleTextMapHash")]
    public Text CoopPageTitleTextMapHash { get; set; }

    [JsonPropertyName("chapterSortId")]
    public int ChapterSortId { get; set; }

    [JsonPropertyName("avatarSortId")]
    public int AvatarSortId { get; set; }

    [JsonPropertyName("chapterIcon")]
    public string ChapterIcon { get; set; } = default!;

    [JsonPropertyName("unlockCond")]
    public IList<ArgsCond> UnlockCond { get; set; } = default!;

    [JsonPropertyName("unlockCondTips")]
    public IList<Text> UnlockCondTips { get; set; } = default!;

    [JsonPropertyName("openMaterialId")]
    public int OpenMaterialId { get; set; }

    [JsonPropertyName("openMaterialNum")]
    public int OpenMaterialNum { get; set; }

    [JsonPropertyName("beginTimeStr")]
    public string BeginTimeStr { get; set; } = default!;

    [JsonPropertyName("confidenceValue")]
    public int ConfidenceValue { get; set; }

    [JsonPropertyName("pointGraphPath")]
    public string PointGraphPath { get; set; } = default!;

    [JsonPropertyName("graphXRatio")]
    public double GraphXRatio { get; set; }

    [JsonPropertyName("graphYRatio")]
    public double GraphYRatio { get; set; }
}