namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonChallengeConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("targetTextTemplateTextMapHash")]
    public Text TargetTextTemplateTextMapHash { get; set; }

    [JsonPropertyName("subTargetTextTemplateTextMapHash")]
    public Text SubTargetTextTemplateTextMapHash { get; set; }

    [JsonPropertyName("progressTextTemplateTextMapHash")]
    public Text ProgressTextTemplateTextMapHash { get; set; }

    [JsonPropertyName("subProgressTextTemplateTextMapHash")]
    public Text SubProgressTextTemplateTextMapHash { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;

    [JsonPropertyName("challengeType")]
    public string ChallengeType { get; set; } = default!;

    [JsonPropertyName("CIBDIABELKJ")]
    public IList<string> CIBDIABELKJ { get; set; } = default!;

    [JsonPropertyName("noSuccessHint")]
    public bool? NoSuccessHint { get; set; }

    [JsonPropertyName("interruptButtonType")]
    public string InterruptButtonType { get; set; } = default!;

    [JsonPropertyName("noFailHint")]
    public bool? NoFailHint { get; set; }

    [JsonPropertyName("isBlockTopTimer")]
    public bool? IsBlockTopTimer { get; set; }

    [JsonPropertyName("subChallengeFadeOutRule")]
    public string SubChallengeFadeOutRule { get; set; } = default!;

    [JsonPropertyName("subChallengeFadeOutDelayTime")]
    public double? SubChallengeFadeOutDelayTime { get; set; }

    [JsonPropertyName("subChallengeBannerRule")]
    public string SubChallengeBannerRule { get; set; } = default!;

    [JsonPropertyName("recordType")]
    public string RecordType { get; set; } = default!;

    [JsonPropertyName("MNPJDJDJHDJ")]
    public bool? MNPJDJDJHDJ { get; set; }

    [JsonPropertyName("activitySkillID")]
    public int? ActivitySkillID { get; set; }

    [JsonPropertyName("isSuccessWhenNotSettled")]
    public bool? IsSuccessWhenNotSettled { get; set; }

    [JsonPropertyName("DJIFPDBGBKF")]
    public bool? DJIFPDBGBKF { get; set; }
}