using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dialog;

public class DialogExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nextDialogs")]
    public IList<long> NextDialogs { get; set; } = default!;

    [JsonPropertyName("talkRole")]
    public IdType TalkRole { get; set; } = default!;

    [JsonPropertyName("talkContentTextMapHash")]
    public Text TalkContentTextMapHash { get; set; }

    [JsonPropertyName("talkTitleTextMapHash")]
    public Text TalkTitleTextMapHash { get; set; }

    [JsonPropertyName("talkRoleNameTextMapHash")]
    public Text TalkRoleNameTextMapHash { get; set; }

    [JsonPropertyName("talkAssetPath")]
    public string TalkAssetPath { get; set; } = default!;

    [JsonPropertyName("talkAssetPathAlter")]
    public string TalkAssetPathAlter { get; set; } = default!;

    [JsonPropertyName("talkAudioName")]
    public string TalkAudioName { get; set; } = default!;

    [JsonPropertyName("actionBefore")]
    public string ActionBefore { get; set; } = default!;

    [JsonPropertyName("actionWhile")]
    public string ActionWhile { get; set; } = default!;

    [JsonPropertyName("actionAfter")]
    public string ActionAfter { get; set; } = default!;

    [JsonPropertyName("optionIcon")]
    public string OptionIcon { get; set; } = default!;

    [JsonPropertyName("talkShowType")]
    public string TalkShowType { get; set; } = default!;

    [JsonPropertyName("groupId")]
    public int? GroupId { get; set; }
}