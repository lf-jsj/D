namespace Snap.Data.Mapper.Model.ExcelBinOutput.Draft;

public class DraftTextDataExcelConfigData : DataObject
{
    [JsonPropertyName("draftId")]
    public int DraftId { get; set; }

    [JsonPropertyName("draftBtnName")]
    public string DraftBtnName { get; set; } = default!;

    [JsonPropertyName("draftBtnTips")]
    public string DraftBtnTips { get; set; } = default!;

    [JsonPropertyName("requirementDescTextMapHash")]
    public Text RequirementDescTextMapHash { get; set; }

    [JsonPropertyName("draftLimitReasonDescTextMapHash")]
    public Text DraftLimitReasonDescTextMapHash { get; set; }

    [JsonPropertyName("limitWarningDescTextMapHash")]
    public Text LimitWarningDescTextMapHash { get; set; }

    [JsonPropertyName("inviteDescTextMapHash")]
    public Text InviteDescTextMapHash { get; set; }

    [JsonPropertyName("inviteGuestDescTextMapHash")]
    public Text InviteGuestDescTextMapHash { get; set; }

    [JsonPropertyName("inviteHostDescTextMapHash")]
    public Text InviteHostDescTextMapHash { get; set; }

    [JsonPropertyName("inviteWarningDescTextMapHash")]
    public Text InviteWarningDescTextMapHash { get; set; }

    [JsonPropertyName("draftTitleTextMapHash")]
    public Text DraftTitleTextMapHash { get; set; }
}
