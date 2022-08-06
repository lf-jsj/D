using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class FettersExcelConfigData : DataObject
{
    [JsonPropertyName("BOEMFGBHLNM")]
    public int BOEMFGBHLNM { get; set; }

    [JsonPropertyName("tips")]
    public IList<Text> Tips { get; set; } = default!;

    [JsonPropertyName("voiceTitleTextMapHash")]
    public Text VoiceTitleTextMapHash { get; set; }

    [JsonPropertyName("voiceFile")]
    public string VoiceFile { get; set; } = default!;

    [JsonPropertyName("voiceFileTextTextMapHash")]
    public Text VoiceFileTextTextMapHash { get; set; }

    [JsonPropertyName("voiceTitleLockedTextMapHash")]
    public Text VoiceTitleLockedTextMapHash { get; set; }

    [JsonPropertyName("fetterId")]
    public int FetterId { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("openConds")]
    public IList<CondTypeParamList> OpenConds { get; set; } = default!;

    [JsonPropertyName("isHiden")]
    public bool? IsHiden { get; set; }
}
