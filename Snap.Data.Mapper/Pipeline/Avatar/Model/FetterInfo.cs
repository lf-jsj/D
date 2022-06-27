using System.Collections.Generic;

namespace Snap.Data.Mapper.Pipeline.Avatar.Model;

public class FetterInfo
{
    public int BirthMonth { get; set; }
    public int BirthDay { get; set; }

    public string Native { get; set; } = default!;
    public string VisionBefore { get; set; } = default!;
    public string VisionAfter { get; set; } = default!;
    public string ConstellationBefore { get; set; } = default!;
    public string ConstellationAfter { get; set; } = default!;

    public string Title { get; set; } = default!;
    public string Detail { get; set; } = default!;
    public string Association { get; set; } = default!;

    public string CvChinese { get; set; } = default!;
    public string CvJapanese { get; set; } = default!;
    public string CvEnglish { get; set; } = default!;
    public string CvKorean { get; set; } = default!;

    public IEnumerable<Fetter> Fetters { get; set; } = default!;
    public IEnumerable<Fetter> FetterStories { get; set; } = default!;
}
