using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class MonsterMultiPlayerExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("PropPer")]
    public IList<PropTypePropValue> PropPer { get; set; } = default!;

    [JsonPropertyName("EndureNum")]
    public IList<int> EndureNum { get; set; } = default!;

    [JsonPropertyName("ElementShield")]
    public IList<float> ElementShield { get; set; } = default!;
}