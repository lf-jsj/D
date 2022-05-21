using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Offering;

public class OfferingLevelUpExcelConfigData : DataObject
{
    [JsonPropertyName("offeringId")]
    public int OfferingId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("actionVec")]
    public IList<IdCount<int>> ActionVec { get; set; } = default!;

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("FJFOAPDLHDF")]
    public IList<ActionTypeParam<string>> FJFOAPDLHDF { get; set; } = default!;

    [JsonPropertyName("cutSceneId")]
    public int? CutSceneId { get; set; }

    [JsonPropertyName("consumeItemConfig")]
    public bool? ConsumeItemConfig { get; set; }

    [JsonPropertyName("HPAAGPAKBKC")]
    public bool? HPAAGPAKBKC { get; set; }
}
