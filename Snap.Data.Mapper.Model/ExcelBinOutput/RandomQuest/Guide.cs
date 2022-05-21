using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class Guide : TypeParam<string>
{
    [JsonPropertyName("guideScene")]
    public int GuideScene { get; set; }

    [JsonPropertyName("guideStyle")]
    public string GuideStyle { get; set; } = default!;
}
