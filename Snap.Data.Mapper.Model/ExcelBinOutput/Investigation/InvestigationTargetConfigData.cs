namespace Snap.Data.Mapper.Model.ExcelBinOutput.Investigation;

public class InvestigationTargetConfigData : DataObject
{
    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("investigationId")]
    public int InvestigationId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("image")]
    public string Image { get; set; } = default!;

    [JsonPropertyName("infoDesTextMapHash")]
    public Text InfoDesTextMapHash { get; set; }

    [JsonPropertyName("guide")]
    public Guide Guide { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }
}