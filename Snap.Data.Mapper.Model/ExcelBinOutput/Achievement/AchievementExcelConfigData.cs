namespace Snap.Data.Mapper.Model.ExcelBinOutput.Achievement;
public class TriggerConfig : DataObject
{
    [JsonPropertyName("triggerType")]
    [PrimaryName]
    public string TriggerType { get; set; } = string.Empty;

    //TODO: trigger converters
    [JsonPropertyName("paramList")]
    [DataArray(Length = 4)]
    public IList<string> ParamList { get; set; } = default!;
}

public class AchievementExcelConfigData : DataObject
{
    [JsonPropertyName("goalId")]
    [ForeignKey]
    public int GoalId { get; set; }

    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public MappedText TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public MappedText DescTextMapHash { get; set; }

    [JsonPropertyName("ps5TitleTextMapHash")]
    public MappedText Ps5TitleTextMapHash { get; set; }

    /// <summary>
    /// string.Empty
    /// 铜
    /// 银
    /// 金
    /// </summary>
    [JsonPropertyName("ttype")]
    public string Ttype { get; set; } = string.Empty;

    [JsonPropertyName("psTrophyId")]
    public string PsTrophyId { get; set; } = string.Empty;

    [JsonPropertyName("ps4TrophyId")]
    public string Ps4TrophyId { get; set; } = string.Empty;

    [JsonPropertyName("ps5TrophyId")]
    public string Ps5TrophyId { get; set; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    //TODO: link up reward
    [JsonPropertyName("finishRewardId")]
    public int FinishRewardId { get; set; }

    [JsonPropertyName("isDeleteWatcherAfterFinish")]
    public bool IsDeleteWatcherAfterFinish { get; set; }

    [JsonPropertyName("id")]
    [PrimaryKey]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public TriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("ps4GroupId")]
    public int? Ps4GroupId { get; set; }

    [JsonPropertyName("ps5GroupId")]
    public int? Ps5GroupId { get; set; }

    [JsonPropertyName("preStageAchievementId")]
    public int? PreStageAchievementId { get; set; }

    /// <summary>
    /// string.Empty
    /// SHOWTYPE_HIDE
    /// </summary>
    [JsonPropertyName("isShow")]
    public string IsShow { get; set; } = default!;

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    /// <summary>
    /// string.Empty
    /// PROGRESSTYPE_FINISH
    /// PROGRESSTYPE_THOUSAND_TO_ONE
    /// </summary>
    [JsonPropertyName("progressShowType")]
    public string ProgressShowType { get; set; } = default!;
}
