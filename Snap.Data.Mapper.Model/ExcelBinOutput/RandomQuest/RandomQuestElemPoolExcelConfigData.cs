using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandomQuest;

public class RandomQuestElemPoolExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("poolId")]
    public int PoolId { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("sampleList")]
    public IList<TypeContent> SampleList { get; set; } = default!;
}