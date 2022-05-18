namespace Snap.Data.Mapper.Model.ExcelBinOutput.MpPlay;

public class MpPlayWatcherConfigData : DataObject
{
    [JsonPropertyName("MpPlayId")]
    public int MpPlayId { get; set; }

    [JsonPropertyName("challengeDescTextMapHash")]
    public Text ChallengeDescTextMapHash { get; set; }

    [JsonPropertyName("challengeTitleTextMapHash")]
    public Text ChallengeTitleTextMapHash { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("isDisuse")]
    public bool IsDisuse { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("isStore")]
    public bool? IsStore { get; set; }
}