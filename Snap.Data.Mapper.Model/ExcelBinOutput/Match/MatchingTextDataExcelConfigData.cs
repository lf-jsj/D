namespace Snap.Data.Mapper.Model.ExcelBinOutput.Match;

public class MatchingTextDataExcelConfigData : DataObject
{
    [JsonPropertyName("matchId")]
    public int MatchId { get; set; }

    [JsonPropertyName("matchIconHashSuffix")]
    public HashSuffix MatchIconHashSuffix { get; set; }

    [JsonPropertyName("matchIconHashPre")]
    public HashPre MatchIconHashPre { get; set; }

    [JsonPropertyName("matchBtnName")]
    public string MatchBtnName { get; set; } = default!;

    [JsonPropertyName("matchBtnTips")]
    public string MatchBtnTips { get; set; } = default!;

    [JsonPropertyName("requirementDescTextMapHash")]
    public Text RequirementDescTextMapHash { get; set; }

    [JsonPropertyName("matchLimitReasonDescTextMapHash")]
    public Text MatchLimitReasonDescTextMapHash { get; set; }

    [JsonPropertyName("limitWarningDescTextMapHash")]
    public Text LimitWarningDescTextMapHash { get; set; }

    [JsonPropertyName("inviteGuestDescTextMapHash")]
    public Text InviteGuestDescTextMapHash { get; set; }

    [JsonPropertyName("inviteHostDescTextMapHash")]
    public Text InviteHostDescTextMapHash { get; set; }

    [JsonPropertyName("matchStartDesc")]
    public string MatchStartDesc { get; set; } = default!;

    [JsonPropertyName("matchTitleTextMapHash")]
    public Text MatchTitleTextMapHash { get; set; }

    [JsonPropertyName("matchSuccessDescTextMapHash")]
    public Text MatchSuccessDescTextMapHash { get; set; }
}