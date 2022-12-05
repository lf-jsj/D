using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fetter;

public class FetterStoryExcelConfigData : DataObject
{
    public Text StoryTitleTextMapHash { get; set; }

    public Text StoryContextTextMapHash { get; set; }

    public Text StoryTitle2TextMapHash { get; set; }

    public Text StoryContext2TextMapHash { get; set; }

    public IList<Text> Tips { get; set; } = default!;

    public Text StoryTitleLockedTextMapHash { get; set; }

    public int FetterId { get; set; }

    public int AvatarId { get; set; }

    public IList<CondTypeParamList> OpenConds { get; set; } = default!;

    public IList<CondTypeParamList> FinishConds { get; set; } = default!;
}