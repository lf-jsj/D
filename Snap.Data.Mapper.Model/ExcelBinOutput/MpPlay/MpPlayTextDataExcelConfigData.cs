namespace Snap.Data.Mapper.Model.ExcelBinOutput.MpPlay;

public class MpPlayTextDataExcelConfigData : DataObject
{
    [JsonPropertyName("mpPlayId")]
    public int MpPlayId { get; set; }

    [JsonPropertyName("questTextMapHash")]
    public Text QuestTextMapHash { get; set; }

    [JsonPropertyName("rewardTextMapHash")]
    public Text RewardTextMapHash { get; set; }

    [JsonPropertyName("inviteTextMapHash")]
    public Text InviteTextMapHash { get; set; }

    [JsonPropertyName("invitedescTextMapHash")]
    public Text InvitedescTextMapHash { get; set; }

    [JsonPropertyName("invitedeschostTextMapHash")]
    public Text InvitedeschostTextMapHash { get; set; }

    [JsonPropertyName("startTextMapHash")]
    public Text StartTextMapHash { get; set; }

    [JsonPropertyName("starttipTextMapHash")]
    public Text StarttipTextMapHash { get; set; }

    [JsonPropertyName("victoryTextMapHash")]
    public Text VictoryTextMapHash { get; set; }

    [JsonPropertyName("failTextMapHash")]
    public Text FailTextMapHash { get; set; }

    [JsonPropertyName("riviveTextMapHash")]
    public Text RiviveTextMapHash { get; set; }

    [JsonPropertyName("timespendTextMapHash")]
    public Text TimespendTextMapHash { get; set; }

    [JsonPropertyName("upAvatarTextTextMapHash")]
    public Text UpAvatarTextTextMapHash { get; set; }
}
