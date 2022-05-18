namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TrialAvatar;
public class TrialAvatarActivityDataExcelConfigData : DataObject
{
    [JsonPropertyName("trialAvatarIndexId")]
    public int TrialAvatarIndexId { get; set; }

    [JsonPropertyName("trialAvatarId")]
    public int TrialAvatarId { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("battleAvatarsList")]
    public string BattleAvatarsList { get; set; } = default!;

    [JsonPropertyName("firstPassReward")]
    public int FirstPassReward { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("briefInfoTextMapHash")]
    public Text BriefInfoTextMapHash { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }
}
