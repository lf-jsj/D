using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class FettersExcelConfigData : DataObject
{
    public IList<Text> Tips { get; set; } = default!;

    public Text VoiceTitleTextMapHash { get; set; }

    public string VoiceFile { get; set; } = default!;

    public Text VoiceFileTextTextMapHash { get; set; }

    public Text VoiceTitleLockedTextMapHash { get; set; }

    public int FetterId { get; set; }

    public int AvatarId { get; set; }

    public IList<CondTypeParamList> OpenConds { get; set; } = default!;

    public bool? IsHiden { get; set; }
}
