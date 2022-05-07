using Snap.Data.Mapper.Converter;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Model.Achievement;

public class Achievement
{
    [JsonPropertyName("goalId")]
    public int GoalId { get; set; }

    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    [JsonConverter(typeof(TextMapHashConverter))]
    public string TitleTextMapHash { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    [JsonConverter(typeof(TextMapHashConverter))]
    public string DescTextMapHash { get; set; } = default!;

    [JsonPropertyName("ps5TitleTextMapHash")]
    [JsonConverter(typeof(TextMapHashConverter))]
    public string Ps5TitleTextMapHash { get; set; } = default!;

    [JsonPropertyName("ttype")]
    public string Ttype { get; set; } = default!;

    [JsonPropertyName("psTrophyId")]
    public string PsTrophyId { get; set; } = default!;

    [JsonPropertyName("ps4TrophyId")]
    public string Ps4TrophyId { get; set; } = default!;

    [JsonPropertyName("ps5TrophyId")]
    public string Ps5TrophyId { get; set; } = default!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("finishRewardId")]
    public int FinishRewardId { get; set; }

    [JsonPropertyName("isDeleteWatcherAfterFinish")]
    public bool IsDeleteWatcherAfterFinish { get; set; }

    [JsonPropertyName("id")]
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

    [JsonPropertyName("isShow")]
    public string IsShow { get; set; } = default!;

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    [JsonPropertyName("progressShowType")]
    public string ProgressShowType { get; set; } = default!;
}
