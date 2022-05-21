namespace Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;

public class AchievementExcelConfigData : DataObject
{
    [JsonPropertyName("goalId")]
    [ForeignKey]
    public int GoalId { get; set; }

    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("ps5TitleTextMapHash")]
    public Text Ps5TitleTextMapHash { get; set; }

    [JsonPropertyName("ttype")]
    public string Ttype { get; set; } = string.Empty;

    [JsonPropertyName("psTrophyId")]
    public string PsTrophyId { get; set; } = string.Empty;

    [JsonPropertyName("ps4TrophyId")]
    public string Ps4TrophyId { get; set; } = string.Empty;

    [JsonPropertyName("ps5TrophyId")]
    public string Ps5TrophyId { get; set; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;

    [JsonPropertyName("finishRewardId")]
    [ForeignKey]
    public int FinishRewardId { get; set; }

    [JsonPropertyName("isDeleteWatcherAfterFinish")]
    public bool IsDeleteWatcherAfterFinish { get; set; }

    [JsonPropertyName("id")]
    [PrimaryKey]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    /// <summary>
    /// <see cref="TriggerConfig"/> 中可能用到的进度
    /// </summary>
    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("ps4GroupId")]
    public int? Ps4GroupId { get; set; }

    [JsonPropertyName("ps5GroupId")]
    public int? Ps5GroupId { get; set; }

    [JsonPropertyName("preStageAchievementId")]
    public int? PreStageAchievementId { get; set; }

    [JsonPropertyName("isShow")]
    public string? IsShow { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    [JsonPropertyName("progressShowType")]
    public string? ProgressShowType { get; set; }
}
