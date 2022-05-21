using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;

public class ReliquaryLevelExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("addProps")]
    public IList<PropTypeValue> AddProps { get; set; } = default!;

    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    [JsonPropertyName("exp")]
    public int? Exp { get; set; }
}