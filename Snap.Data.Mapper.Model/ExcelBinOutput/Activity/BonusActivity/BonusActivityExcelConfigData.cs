using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BonusActivity;

public class BonusActivityExcelConfigData : DataObject
{
    [JsonPropertyName("bonusActivityId")]
    public int BonusActivityId { get; set; }

    [JsonPropertyName("condList")]
    public IList<TypeParamList> CondList { get; set; } = default!;

    [JsonPropertyName("watcherId")]
    public int WatcherId { get; set; }

    [JsonPropertyName("rewardItemList")]
    public IList<IdCount<int>> RewardItemList { get; set; } = default!;

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("triggerConfig")]
    public ParamListTriggerConfig TriggerConfig { get; set; } = default!;

    [JsonPropertyName("progress")]
    public int Progress { get; set; }
}
