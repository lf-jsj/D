namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class FetterInfoExcelConfigData : DataObject
{
    [JsonPropertyName("infoBirthMonth")]
    public int InfoBirthMonth { get; set; }

    [JsonPropertyName("infoBirthDay")]
    public int InfoBirthDay { get; set; }

    [JsonPropertyName("avatarNativeTextMapHash")]
    public Text AvatarNativeTextMapHash { get; set; }

    [JsonPropertyName("avatarVisionBeforTextMapHash")]
    public Text AvatarVisionBeforTextMapHash { get; set; }

    [JsonPropertyName("avatarConstellationBeforTextMapHash")]
    public Text AvatarConstellationBeforTextMapHash { get; set; }

    [JsonPropertyName("avatarTitleTextMapHash")]
    public Text AvatarTitleTextMapHash { get; set; }

    [JsonPropertyName("avatarDetailTextMapHash")]
    public Text AvatarDetailTextMapHash { get; set; }

    [JsonPropertyName("avatarAssocType")]
    public string AvatarAssocType { get; set; } = default!;

    [JsonPropertyName("cvChineseTextMapHash")]
    public Text CvChineseTextMapHash { get; set; }

    [JsonPropertyName("cvJapaneseTextMapHash")]
    public Text CvJapaneseTextMapHash { get; set; }

    [JsonPropertyName("cvEnglishTextMapHash")]
    public Text CvEnglishTextMapHash { get; set; }

    [JsonPropertyName("cvKoreanTextMapHash")]
    public Text CvKoreanTextMapHash { get; set; }

    [JsonPropertyName("avatarVisionAfterTextMapHash")]
    public Text AvatarVisionAfterTextMapHash { get; set; }

    [JsonPropertyName("avatarConstellationAfterTextMapHash")]
    public Text AvatarConstellationAfterTextMapHash { get; set; }

    [JsonPropertyName("fetterId")]
    public int FetterId { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("openConds")]
    public IList<DataObject> OpenConds { get; set; } = default!;

    [JsonPropertyName("finishConds")]
    public IList<ParamListCondType> FinishConds { get; set; } = default!;
}
