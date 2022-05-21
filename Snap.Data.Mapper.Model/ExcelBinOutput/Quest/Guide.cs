using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class Guide : TypeParam<string>
{
    [JsonPropertyName("guideScene")]
    public int? GuideScene { get; set; }

    [JsonPropertyName("guideStyle")]
    public string GuideStyle { get; set; } = default!;

    [JsonPropertyName("guideLayer")]
    public string GuideLayer { get; set; } = default!;

    [JsonPropertyName("autoGuide")]
    public string AutoGuide { get; set; } = default!;
}