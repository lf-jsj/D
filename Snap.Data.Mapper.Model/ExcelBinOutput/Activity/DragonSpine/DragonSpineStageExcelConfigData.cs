namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.DragonSpine;

public class DragonSpineStageExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("coinIdList")]
    public IList<int> CoinIdList { get; set; } = default!;

    [JsonPropertyName("openday")]
    public int Openday { get; set; }

    [JsonPropertyName("preQuestId")]
    public int PreQuestId { get; set; }

    [JsonPropertyName("missionIdList")]
    public IList<int> MissionIdList { get; set; } = default!;

    [JsonPropertyName("rewardPreviewId")]
    public int? RewardPreviewId { get; set; }
}