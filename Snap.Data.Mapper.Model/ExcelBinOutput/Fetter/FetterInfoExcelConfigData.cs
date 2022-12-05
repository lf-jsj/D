namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class FetterInfoExcelConfigData : DataObject
{
    public int InfoBirthMonth { get; set; }

    public int InfoBirthDay { get; set; }

    public Text AvatarNativeTextMapHash { get; set; }

    public Text AvatarVisionBeforTextMapHash { get; set; }

    public Text AvatarConstellationBeforTextMapHash { get; set; }

    public Text AvatarTitleTextMapHash { get; set; }

    public Text AvatarDetailTextMapHash { get; set; }

    public AssocType AvatarAssocType { get; set; } = default!;

    public Text CvChineseTextMapHash { get; set; }

    public Text CvJapaneseTextMapHash { get; set; }

    public Text CvEnglishTextMapHash { get; set; }

    public Text CvKoreanTextMapHash { get; set; }

    public Text AvatarVisionAfterTextMapHash { get; set; }

    public Text AvatarConstellationAfterTextMapHash { get; set; }

    public int FetterId { get; set; }

    public int AvatarId { get; set; }

    public IList<DataObject> OpenConds { get; set; } = default!;
}